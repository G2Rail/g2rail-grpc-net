// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/OnlineTickets.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace G2Rail.Protobuf {
  /// <summary>
  /// Interface exported by the server, it allows download pdf tickets or mobile tickets.
  /// </summary>
  public static partial class OnlineTickets
  {
    static readonly string __ServiceName = "g2rail.OnlineTickets";

    static readonly grpc::Marshaller<global::G2Rail.Protobuf.DownloadRequest> __Marshaller_g2rail_DownloadRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::G2Rail.Protobuf.DownloadRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::G2Rail.Protobuf.TicketsResponse> __Marshaller_g2rail_TicketsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::G2Rail.Protobuf.TicketsResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::G2Rail.Protobuf.DownloadRequest, global::G2Rail.Protobuf.TicketsResponse> __Method_Download = new grpc::Method<global::G2Rail.Protobuf.DownloadRequest, global::G2Rail.Protobuf.TicketsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Download",
        __Marshaller_g2rail_DownloadRequest,
        __Marshaller_g2rail_TicketsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::G2Rail.Protobuf.OnlineTicketsReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for OnlineTickets</summary>
    public partial class OnlineTicketsClient : grpc::ClientBase<OnlineTicketsClient>
    {
      /// <summary>Creates a new client for OnlineTickets</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public OnlineTicketsClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for OnlineTickets that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public OnlineTicketsClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected OnlineTicketsClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected OnlineTicketsClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Send a tickets downloading request
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::G2Rail.Protobuf.TicketsResponse Download(global::G2Rail.Protobuf.DownloadRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Download(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Send a tickets downloading request
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::G2Rail.Protobuf.TicketsResponse Download(global::G2Rail.Protobuf.DownloadRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Download, null, options, request);
      }
      /// <summary>
      /// Send a tickets downloading request
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::G2Rail.Protobuf.TicketsResponse> DownloadAsync(global::G2Rail.Protobuf.DownloadRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DownloadAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Send a tickets downloading request
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::G2Rail.Protobuf.TicketsResponse> DownloadAsync(global::G2Rail.Protobuf.DownloadRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Download, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override OnlineTicketsClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new OnlineTicketsClient(configuration);
      }
    }

  }
}
#endregion