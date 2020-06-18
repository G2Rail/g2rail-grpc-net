using System;
using Grpc.Core;
using Grpc.Core.Interceptors;

namespace client.Interceptors
{
    public class AuthenticationInterceptor : Interceptor
    {
        private MessageSignature messageSignature;
        private string apiKey;


        public AuthenticationInterceptor(string apiKey, MessageSignature messageSignature)
        {
            this.apiKey = apiKey;
            this.messageSignature = messageSignature;
        }

        public override TResponse BlockingUnaryCall<TRequest, TResponse>(TRequest request, ClientInterceptorContext<TRequest, TResponse> context, BlockingUnaryCallContinuation<TRequest, TResponse> continuation)
        {
            var headers = context.Options.Headers;

            // Call doesn't have a headers collection to add to.
            // Need to create a new context with headers for the call.
            if (headers == null)
            {
                headers = new Metadata();
                var options = context.Options.WithHeaders(headers);
                context = new ClientInterceptorContext<TRequest, TResponse>(context.Method, context.Host, options);
            }

            // Add caller metadata to call headers
            headers.Add("from", this.apiKey);
            headers.Add("date", DateTime.Now.ToUniversalTime().ToString("r"));
            headers.Add("authorization", messageSignature.calculateSign());

            return base.BlockingUnaryCall(request, context, continuation);
        }
    }
}
