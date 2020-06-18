using System;
using System.Threading;
using System.Threading.Tasks;
using client.Interceptors;
using G2Rail.Protobuf;
using Google.Protobuf;
using Grpc.Core.Interceptors;
using Grpc.Net.Client;
using System.Linq;
using dotenv.net;
using dotenv.net.Utilities;

namespace client
{
    class Program
    {
        static void Main(string[] args)
        {
            AppContext.SetSwitch(
                "System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);
            DotEnv.Config(false);

            var envReader = new EnvReader();
            var apiKey = envReader.GetStringValue("API_KEY");
            var apiSecret = envReader.GetStringValue("API_SECRET");

            var host = envReader.GetStringValue("HOST");
            var port = envReader.GetIntValue("PORT");
            Console.WriteLine(string.Format("http://{0}:{1}", host, port));
            using (var channel = GrpcChannel.ForAddress(String.Format("http://{0}:{1}", host, port)))
            {
                SearchRequest searchRequest = new SearchRequest
                {
                    From = "BERLIN",
                    To = "FRANKFURT",
                    Date = "2020-6-22",
                    Time = "07:00",
                    Adult = 1,
                    Child = 0
                };

                var authenticationInterceptor = new AuthenticationInterceptor(apiKey, new MessageSignature(apiKey, apiSecret, searchRequest));
                var client = new OnlineSolutions.OnlineSolutionsClient(channel.Intercept(authenticationInterceptor));

                var asyncResponse = client.Search(searchRequest);
                var asyncKey = asyncResponse.AsyncKey;
                Console.WriteLine("Search Result At: " + asyncResponse.AsyncKey);
                if (string.IsNullOrEmpty(asyncKey))
                {
                    Console.WriteLine("Async Key Fetch Error");
                    return;
                }

                var queryOnlineSolutionRequest = new OnlineSolutionsAsyncQueryRequest { AsyncKey = asyncKey };
                authenticationInterceptor = new AuthenticationInterceptor(apiKey, new MessageSignature(apiKey, apiSecret, queryOnlineSolutionRequest));

                client = new OnlineSolutions.OnlineSolutionsClient(channel.Intercept(authenticationInterceptor));
                OnlineSolutionsResponse searchResponse;

                do
                {
                    searchResponse = client.QueryAsyncOnlineSolutions(queryOnlineSolutionRequest);
                    Console.WriteLine(searchResponse.ToString());
                    Thread.Sleep(2000);
                } while (searchResponse.RailwaySolutions.Any(x => x.Loading));

            }

            
            Console.ReadKey();
            
        }
    }
}
