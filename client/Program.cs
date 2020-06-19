using System;
using System.Threading;
using client.Interceptors;
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
                /**
                 * Initiate Search Request
                 */
                G2Rail.Protobuf.SearchRequest searchRequest = new G2Rail.Protobuf.SearchRequest
                {
                    From = "BERLIN",
                    To = "FRANKFURT",
                    Date = "2020-6-22",
                    Time = "07:00",
                    Adult = 1,
                    Child = 0
                };

                var authenticationInterceptor = new AuthenticationInterceptor(apiKey, new MessageSignature(apiKey, apiSecret, searchRequest));
                var client = new G2Rail.Protobuf.OnlineSolutions.OnlineSolutionsClient(channel.Intercept(authenticationInterceptor));

                var asyncResponse = client.Search(searchRequest);
                var asyncKey = asyncResponse.AsyncKey;
                Console.WriteLine("Search Result At: " + asyncResponse.AsyncKey);
                if (string.IsNullOrEmpty(asyncKey))
                {
                    Console.WriteLine("Async Key Fetch Error");
                    return;
                }
                /**
                 * Retrieve Search Response
                 */
                var queryOnlineSolutionRequest = new G2Rail.Protobuf.OnlineSolutionsAsyncQueryRequest { AsyncKey = asyncKey };
                authenticationInterceptor = new AuthenticationInterceptor(apiKey, new MessageSignature(apiKey, apiSecret, queryOnlineSolutionRequest));

                client = new G2Rail.Protobuf.OnlineSolutions.OnlineSolutionsClient(channel.Intercept(authenticationInterceptor));
                G2Rail.Protobuf.OnlineSolutionsResponse searchResponse;

                do
                {
                    searchResponse = client.QueryAsyncOnlineSolutions(queryOnlineSolutionRequest);
                    Console.WriteLine(searchResponse.ToString());
                    Thread.Sleep(2000);
                } while (searchResponse.RailwaySolutions.Any(x => x.Loading));


                /**
                 *  Start Booking by find the first booking code.
                 */
                var bookingCode = searchResponse.RailwaySolutions.ElementAt<G2Rail.Protobuf.RailwaySolution>(0).Solutions[0].Sections[0].Offers[1].Services[0].BookingCode;


                var bookRequest = new G2Rail.Protobuf.BookRequest
                {
                    Sections = { bookingCode },
                    Passengers =
                    {
                        new G2Rail.Protobuf.Passenger
                        {
                            Gender =   G2Rail.Protobuf.Passenger.Types.Gender.Male,
			                FirstName = "QINWEN",
			                LastName = "SHI",
			                Passport = "E12341813",
			                Phone = "+8527892123",
			                Email = "wen@g2rail.com",
			                Birthdate = "1986-06-01",
                        }
                    }

                };

                authenticationInterceptor = new AuthenticationInterceptor(apiKey, new MessageSignature(apiKey, apiSecret, bookRequest));
                var onlineOrderClient = new G2Rail.Protobuf.OnlineOrders.OnlineOrdersClient(channel.Intercept(authenticationInterceptor));
                var bookAsyncKey = onlineOrderClient.Book(bookRequest).AsyncKey;

                Console.WriteLine("Order will be at :" + bookAsyncKey);

                /*
                 * Retireve Online Order
                 */
                var queryOnlineOrderRequest = new G2Rail.Protobuf.OnlineOrderAsyncQueryRequest { AsyncKey = bookAsyncKey };
                G2Rail.Protobuf.OnlineOrderResponse onlineOrderResponse;
                do
                {
                    Console.WriteLine("Load Book Result From: " + bookAsyncKey);
                    authenticationInterceptor = new AuthenticationInterceptor(apiKey, new MessageSignature(apiKey, apiSecret, queryOnlineOrderRequest));
                    onlineOrderClient = new G2Rail.Protobuf.OnlineOrders.OnlineOrdersClient(channel.Intercept(authenticationInterceptor));
                    onlineOrderResponse = onlineOrderClient.QueryAsyncOnlineOrder(queryOnlineOrderRequest);
                    Thread.Sleep(3000);
                } while (onlineOrderResponse.Loading);

                Console.WriteLine(onlineOrderResponse.ToString());

                /**
                 *  Confirm the order and issue tickets.
                 */
                

                var confirmRequest = new G2Rail.Protobuf.ConfirmRequest
                {
                    OrderId = onlineOrderResponse.Id

                };

                authenticationInterceptor = new AuthenticationInterceptor(apiKey, new MessageSignature(apiKey, apiSecret, confirmRequest));
                var onlineConfirmationClient = new G2Rail.Protobuf.OnlineConfirmations.OnlineConfirmationsClient(channel.Intercept(authenticationInterceptor));
                var confirmationAsyncKey = onlineConfirmationClient.Confirm(confirmRequest).AsyncKey;

                Console.WriteLine("Confirmation will be at :" + confirmationAsyncKey);

                /*
                 * Retireve Confirmation Result with PNR etc.
                 */
                var queryOnlineConfirmationRequest = new G2Rail.Protobuf.OnlineConfirmationAsyncQueryRequest { AsyncKey = confirmationAsyncKey };
                G2Rail.Protobuf.OnlineConfirmationResponse onlineConfirmationResponse;
                do
                {
                    Console.WriteLine("Load Confirm Result From: " + bookAsyncKey);
                    authenticationInterceptor = new AuthenticationInterceptor(apiKey, new MessageSignature(apiKey, apiSecret, queryOnlineConfirmationRequest));
                    onlineConfirmationClient = new G2Rail.Protobuf.OnlineConfirmations.OnlineConfirmationsClient(channel.Intercept(authenticationInterceptor));
                    onlineConfirmationResponse = onlineConfirmationClient.QueryAsyncOnlineConfirmation(queryOnlineConfirmationRequest);
                    Thread.Sleep(3000);
                } while (onlineConfirmationResponse.Loading);

                Console.WriteLine(onlineConfirmationResponse.ToString());
            }

            Console.ReadKey();
            
        }
    }
}
