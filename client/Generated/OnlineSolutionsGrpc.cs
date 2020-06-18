// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/OnlineSolutions.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace G2Rail.Protobuf {
  /// <summary>
  /// Interface exported by the server.
  /// </summary>
  public static partial class OnlineSolutions
  {
    static readonly string __ServiceName = "g2rail.OnlineSolutions";

    static readonly grpc::Marshaller<global::G2Rail.Protobuf.SearchRequest> __Marshaller_g2rail_SearchRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::G2Rail.Protobuf.SearchRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::G2Rail.Protobuf.AsyncKeyResponse> __Marshaller_g2rail_AsyncKeyResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::G2Rail.Protobuf.AsyncKeyResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::G2Rail.Protobuf.OnlineSolutionsAsyncQueryRequest> __Marshaller_g2rail_OnlineSolutionsAsyncQueryRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::G2Rail.Protobuf.OnlineSolutionsAsyncQueryRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::G2Rail.Protobuf.OnlineSolutionsResponse> __Marshaller_g2rail_OnlineSolutionsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::G2Rail.Protobuf.OnlineSolutionsResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::G2Rail.Protobuf.SearchRequest, global::G2Rail.Protobuf.AsyncKeyResponse> __Method_Search = new grpc::Method<global::G2Rail.Protobuf.SearchRequest, global::G2Rail.Protobuf.AsyncKeyResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Search",
        __Marshaller_g2rail_SearchRequest,
        __Marshaller_g2rail_AsyncKeyResponse);

    static readonly grpc::Method<global::G2Rail.Protobuf.OnlineSolutionsAsyncQueryRequest, global::G2Rail.Protobuf.OnlineSolutionsResponse> __Method_QueryAsyncOnlineSolutions = new grpc::Method<global::G2Rail.Protobuf.OnlineSolutionsAsyncQueryRequest, global::G2Rail.Protobuf.OnlineSolutionsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "QueryAsyncOnlineSolutions",
        __Marshaller_g2rail_OnlineSolutionsAsyncQueryRequest,
        __Marshaller_g2rail_OnlineSolutionsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::G2Rail.Protobuf.OnlineSolutionsReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for OnlineSolutions</summary>
    public partial class OnlineSolutionsClient : grpc::ClientBase<OnlineSolutionsClient>
    {
      /// <summary>Creates a new client for OnlineSolutions</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public OnlineSolutionsClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for OnlineSolutions that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public OnlineSolutionsClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected OnlineSolutionsClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected OnlineSolutionsClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Send a search request
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::G2Rail.Protobuf.AsyncKeyResponse Search(global::G2Rail.Protobuf.SearchRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Search(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Send a search request
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::G2Rail.Protobuf.AsyncKeyResponse Search(global::G2Rail.Protobuf.SearchRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Search, null, options, request);
      }
      /// <summary>
      /// Send a search request
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::G2Rail.Protobuf.AsyncKeyResponse> SearchAsync(global::G2Rail.Protobuf.SearchRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SearchAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Send a search request
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::G2Rail.Protobuf.AsyncKeyResponse> SearchAsync(global::G2Rail.Protobuf.SearchRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Search, null, options, request);
      }
      /// <summary>
      /// Service to query async result by using the async key
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::G2Rail.Protobuf.OnlineSolutionsResponse QueryAsyncOnlineSolutions(global::G2Rail.Protobuf.OnlineSolutionsAsyncQueryRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return QueryAsyncOnlineSolutions(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Service to query async result by using the async key
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::G2Rail.Protobuf.OnlineSolutionsResponse QueryAsyncOnlineSolutions(global::G2Rail.Protobuf.OnlineSolutionsAsyncQueryRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_QueryAsyncOnlineSolutions, null, options, request);
      }
      /// <summary>
      /// Service to query async result by using the async key
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::G2Rail.Protobuf.OnlineSolutionsResponse> QueryAsyncOnlineSolutionsAsync(global::G2Rail.Protobuf.OnlineSolutionsAsyncQueryRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return QueryAsyncOnlineSolutionsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Service to query async result by using the async key
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::G2Rail.Protobuf.OnlineSolutionsResponse> QueryAsyncOnlineSolutionsAsync(global::G2Rail.Protobuf.OnlineSolutionsAsyncQueryRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_QueryAsyncOnlineSolutions, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override OnlineSolutionsClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new OnlineSolutionsClient(configuration);
      }
    }

  }
}
#endregion
