// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/OnlineOrders.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace G2Rail.Protobuf {

  /// <summary>Holder for reflection information generated from Protos/OnlineOrders.proto</summary>
  public static partial class OnlineOrdersReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/OnlineOrders.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static OnlineOrdersReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChlQcm90b3MvT25saW5lT3JkZXJzLnByb3RvEgZnMnJhaWwaE1Byb3Rvcy9D",
            "b21tb24ucHJvdG8iXQoLQm9va1JlcXVlc3QSFQoNc2VhdF9yZXNlcnZlZBgB",
            "IAEoCBIQCghzZWN0aW9ucxgCIAMoCRIlCgpwYXNzZW5nZXJzGAMgAygLMhEu",
            "ZzJyYWlsLlBhc3NlbmdlciIxChxPbmxpbmVPcmRlckFzeW5jUXVlcnlSZXF1",
            "ZXN0EhEKCWFzeW5jX2tleRgBIAEoCSKRBAoTT25saW5lT3JkZXJSZXNwb25z",
            "ZRIKCgJpZBgBIAEoCRIPCgdsb2FkaW5nGA4gASgIEhsKE29mZmxpbmVfZnVs",
            "ZmlsbG1lbnQYDyABKAgSGQoRdHJhaW5fZGVzY3JpcHRpb24YECABKAkSIAoH",
            "cmFpbHdheRgCIAEoCzIPLmcycmFpbC5SYWlsd2F5Eh0KBGZyb20YAyABKAsy",
            "Dy5nMnJhaWwuU3RhdGlvbhIbCgJ0bxgEIAEoCzIPLmcycmFpbC5TdGF0aW9u",
            "EhEKCWRlcGFydHVyZRgFIAEoCRIPCgdhcnJpdmFsGAYgASgJEiMKDHRpY2tl",
            "dF9wcmljZRgHIAEoCzINLmcycmFpbC5QcmljZRIkCg1wYXltZW50X3ByaWNl",
            "GAggASgLMg0uZzJyYWlsLlByaWNlEiUKDmNoYXJnaW5nX3ByaWNlGAkgASgL",
            "Mg0uZzJyYWlsLlByaWNlEiQKDXJlYmF0ZV9hbW91bnQYCiABKAsyDS5nMnJh",
            "aWwuUHJpY2USHQoGdHJhaW5zGBEgAygLMg0uZzJyYWlsLlRyYWluEiUKCnBh",
            "c3NlbmdlcnMYCyADKAsyES5nMnJhaWwuUGFzc2VuZ2VyEh8KB3RpY2tldHMY",
            "DCADKAsyDi5nMnJhaWwuVGlja2V0EiQKB3JlY29yZHMYDSADKAsyEy5nMnJh",
            "aWwuUHJpY2VEZXRhaWwyoQEKDE9ubGluZU9yZGVycxI1CgRCb29rEhMuZzJy",
            "YWlsLkJvb2tSZXF1ZXN0GhguZzJyYWlsLkFzeW5jS2V5UmVzcG9uc2USWgoV",
            "UXVlcnlBc3luY09ubGluZU9yZGVyEiQuZzJyYWlsLk9ubGluZU9yZGVyQXN5",
            "bmNRdWVyeVJlcXVlc3QaGy5nMnJhaWwuT25saW5lT3JkZXJSZXNwb25zZUI/",
            "Cg5pby5ncnBjLmcycmFpbEIRT25saW5lT3JkZXJzUHJvdG9QAVoGZzJyYWls",
            "qgIPRzJSYWlsLlByb3RvYnVmYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::G2Rail.Protobuf.CommonReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::G2Rail.Protobuf.BookRequest), global::G2Rail.Protobuf.BookRequest.Parser, new[]{ "SeatReserved", "Sections", "Passengers" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::G2Rail.Protobuf.OnlineOrderAsyncQueryRequest), global::G2Rail.Protobuf.OnlineOrderAsyncQueryRequest.Parser, new[]{ "AsyncKey" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::G2Rail.Protobuf.OnlineOrderResponse), global::G2Rail.Protobuf.OnlineOrderResponse.Parser, new[]{ "Id", "Loading", "OfflineFulfillment", "TrainDescription", "Railway", "From", "To", "Departure", "Arrival", "TicketPrice", "PaymentPrice", "ChargingPrice", "RebateAmount", "Trains", "Passengers", "Tickets", "Records" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class BookRequest : pb::IMessage<BookRequest> {
    private static readonly pb::MessageParser<BookRequest> _parser = new pb::MessageParser<BookRequest>(() => new BookRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<BookRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::G2Rail.Protobuf.OnlineOrdersReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BookRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BookRequest(BookRequest other) : this() {
      seatReserved_ = other.seatReserved_;
      sections_ = other.sections_.Clone();
      passengers_ = other.passengers_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public BookRequest Clone() {
      return new BookRequest(this);
    }

    /// <summary>Field number for the "seat_reserved" field.</summary>
    public const int SeatReservedFieldNumber = 1;
    private bool seatReserved_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool SeatReserved {
      get { return seatReserved_; }
      set {
        seatReserved_ = value;
      }
    }

    /// <summary>Field number for the "sections" field.</summary>
    public const int SectionsFieldNumber = 2;
    private static readonly pb::FieldCodec<string> _repeated_sections_codec
        = pb::FieldCodec.ForString(18);
    private readonly pbc::RepeatedField<string> sections_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> Sections {
      get { return sections_; }
    }

    /// <summary>Field number for the "passengers" field.</summary>
    public const int PassengersFieldNumber = 3;
    private static readonly pb::FieldCodec<global::G2Rail.Protobuf.Passenger> _repeated_passengers_codec
        = pb::FieldCodec.ForMessage(26, global::G2Rail.Protobuf.Passenger.Parser);
    private readonly pbc::RepeatedField<global::G2Rail.Protobuf.Passenger> passengers_ = new pbc::RepeatedField<global::G2Rail.Protobuf.Passenger>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::G2Rail.Protobuf.Passenger> Passengers {
      get { return passengers_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as BookRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(BookRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SeatReserved != other.SeatReserved) return false;
      if(!sections_.Equals(other.sections_)) return false;
      if(!passengers_.Equals(other.passengers_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (SeatReserved != false) hash ^= SeatReserved.GetHashCode();
      hash ^= sections_.GetHashCode();
      hash ^= passengers_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (SeatReserved != false) {
        output.WriteRawTag(8);
        output.WriteBool(SeatReserved);
      }
      sections_.WriteTo(output, _repeated_sections_codec);
      passengers_.WriteTo(output, _repeated_passengers_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (SeatReserved != false) {
        size += 1 + 1;
      }
      size += sections_.CalculateSize(_repeated_sections_codec);
      size += passengers_.CalculateSize(_repeated_passengers_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(BookRequest other) {
      if (other == null) {
        return;
      }
      if (other.SeatReserved != false) {
        SeatReserved = other.SeatReserved;
      }
      sections_.Add(other.sections_);
      passengers_.Add(other.passengers_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            SeatReserved = input.ReadBool();
            break;
          }
          case 18: {
            sections_.AddEntriesFrom(input, _repeated_sections_codec);
            break;
          }
          case 26: {
            passengers_.AddEntriesFrom(input, _repeated_passengers_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class OnlineOrderAsyncQueryRequest : pb::IMessage<OnlineOrderAsyncQueryRequest> {
    private static readonly pb::MessageParser<OnlineOrderAsyncQueryRequest> _parser = new pb::MessageParser<OnlineOrderAsyncQueryRequest>(() => new OnlineOrderAsyncQueryRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<OnlineOrderAsyncQueryRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::G2Rail.Protobuf.OnlineOrdersReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OnlineOrderAsyncQueryRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OnlineOrderAsyncQueryRequest(OnlineOrderAsyncQueryRequest other) : this() {
      asyncKey_ = other.asyncKey_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OnlineOrderAsyncQueryRequest Clone() {
      return new OnlineOrderAsyncQueryRequest(this);
    }

    /// <summary>Field number for the "async_key" field.</summary>
    public const int AsyncKeyFieldNumber = 1;
    private string asyncKey_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string AsyncKey {
      get { return asyncKey_; }
      set {
        asyncKey_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as OnlineOrderAsyncQueryRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(OnlineOrderAsyncQueryRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (AsyncKey != other.AsyncKey) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (AsyncKey.Length != 0) hash ^= AsyncKey.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (AsyncKey.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(AsyncKey);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (AsyncKey.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AsyncKey);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(OnlineOrderAsyncQueryRequest other) {
      if (other == null) {
        return;
      }
      if (other.AsyncKey.Length != 0) {
        AsyncKey = other.AsyncKey;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            AsyncKey = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class OnlineOrderResponse : pb::IMessage<OnlineOrderResponse> {
    private static readonly pb::MessageParser<OnlineOrderResponse> _parser = new pb::MessageParser<OnlineOrderResponse>(() => new OnlineOrderResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<OnlineOrderResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::G2Rail.Protobuf.OnlineOrdersReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OnlineOrderResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OnlineOrderResponse(OnlineOrderResponse other) : this() {
      id_ = other.id_;
      loading_ = other.loading_;
      offlineFulfillment_ = other.offlineFulfillment_;
      trainDescription_ = other.trainDescription_;
      railway_ = other.railway_ != null ? other.railway_.Clone() : null;
      from_ = other.from_ != null ? other.from_.Clone() : null;
      to_ = other.to_ != null ? other.to_.Clone() : null;
      departure_ = other.departure_;
      arrival_ = other.arrival_;
      ticketPrice_ = other.ticketPrice_ != null ? other.ticketPrice_.Clone() : null;
      paymentPrice_ = other.paymentPrice_ != null ? other.paymentPrice_.Clone() : null;
      chargingPrice_ = other.chargingPrice_ != null ? other.chargingPrice_.Clone() : null;
      rebateAmount_ = other.rebateAmount_ != null ? other.rebateAmount_.Clone() : null;
      trains_ = other.trains_.Clone();
      passengers_ = other.passengers_.Clone();
      tickets_ = other.tickets_.Clone();
      records_ = other.records_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public OnlineOrderResponse Clone() {
      return new OnlineOrderResponse(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "loading" field.</summary>
    public const int LoadingFieldNumber = 14;
    private bool loading_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Loading {
      get { return loading_; }
      set {
        loading_ = value;
      }
    }

    /// <summary>Field number for the "offline_fulfillment" field.</summary>
    public const int OfflineFulfillmentFieldNumber = 15;
    private bool offlineFulfillment_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool OfflineFulfillment {
      get { return offlineFulfillment_; }
      set {
        offlineFulfillment_ = value;
      }
    }

    /// <summary>Field number for the "train_description" field.</summary>
    public const int TrainDescriptionFieldNumber = 16;
    private string trainDescription_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string TrainDescription {
      get { return trainDescription_; }
      set {
        trainDescription_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "railway" field.</summary>
    public const int RailwayFieldNumber = 2;
    private global::G2Rail.Protobuf.Railway railway_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::G2Rail.Protobuf.Railway Railway {
      get { return railway_; }
      set {
        railway_ = value;
      }
    }

    /// <summary>Field number for the "from" field.</summary>
    public const int FromFieldNumber = 3;
    private global::G2Rail.Protobuf.Station from_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::G2Rail.Protobuf.Station From {
      get { return from_; }
      set {
        from_ = value;
      }
    }

    /// <summary>Field number for the "to" field.</summary>
    public const int ToFieldNumber = 4;
    private global::G2Rail.Protobuf.Station to_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::G2Rail.Protobuf.Station To {
      get { return to_; }
      set {
        to_ = value;
      }
    }

    /// <summary>Field number for the "departure" field.</summary>
    public const int DepartureFieldNumber = 5;
    private string departure_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Departure {
      get { return departure_; }
      set {
        departure_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "arrival" field.</summary>
    public const int ArrivalFieldNumber = 6;
    private string arrival_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Arrival {
      get { return arrival_; }
      set {
        arrival_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "ticket_price" field.</summary>
    public const int TicketPriceFieldNumber = 7;
    private global::G2Rail.Protobuf.Price ticketPrice_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::G2Rail.Protobuf.Price TicketPrice {
      get { return ticketPrice_; }
      set {
        ticketPrice_ = value;
      }
    }

    /// <summary>Field number for the "payment_price" field.</summary>
    public const int PaymentPriceFieldNumber = 8;
    private global::G2Rail.Protobuf.Price paymentPrice_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::G2Rail.Protobuf.Price PaymentPrice {
      get { return paymentPrice_; }
      set {
        paymentPrice_ = value;
      }
    }

    /// <summary>Field number for the "charging_price" field.</summary>
    public const int ChargingPriceFieldNumber = 9;
    private global::G2Rail.Protobuf.Price chargingPrice_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::G2Rail.Protobuf.Price ChargingPrice {
      get { return chargingPrice_; }
      set {
        chargingPrice_ = value;
      }
    }

    /// <summary>Field number for the "rebate_amount" field.</summary>
    public const int RebateAmountFieldNumber = 10;
    private global::G2Rail.Protobuf.Price rebateAmount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::G2Rail.Protobuf.Price RebateAmount {
      get { return rebateAmount_; }
      set {
        rebateAmount_ = value;
      }
    }

    /// <summary>Field number for the "trains" field.</summary>
    public const int TrainsFieldNumber = 17;
    private static readonly pb::FieldCodec<global::G2Rail.Protobuf.Train> _repeated_trains_codec
        = pb::FieldCodec.ForMessage(138, global::G2Rail.Protobuf.Train.Parser);
    private readonly pbc::RepeatedField<global::G2Rail.Protobuf.Train> trains_ = new pbc::RepeatedField<global::G2Rail.Protobuf.Train>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::G2Rail.Protobuf.Train> Trains {
      get { return trains_; }
    }

    /// <summary>Field number for the "passengers" field.</summary>
    public const int PassengersFieldNumber = 11;
    private static readonly pb::FieldCodec<global::G2Rail.Protobuf.Passenger> _repeated_passengers_codec
        = pb::FieldCodec.ForMessage(90, global::G2Rail.Protobuf.Passenger.Parser);
    private readonly pbc::RepeatedField<global::G2Rail.Protobuf.Passenger> passengers_ = new pbc::RepeatedField<global::G2Rail.Protobuf.Passenger>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::G2Rail.Protobuf.Passenger> Passengers {
      get { return passengers_; }
    }

    /// <summary>Field number for the "tickets" field.</summary>
    public const int TicketsFieldNumber = 12;
    private static readonly pb::FieldCodec<global::G2Rail.Protobuf.Ticket> _repeated_tickets_codec
        = pb::FieldCodec.ForMessage(98, global::G2Rail.Protobuf.Ticket.Parser);
    private readonly pbc::RepeatedField<global::G2Rail.Protobuf.Ticket> tickets_ = new pbc::RepeatedField<global::G2Rail.Protobuf.Ticket>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::G2Rail.Protobuf.Ticket> Tickets {
      get { return tickets_; }
    }

    /// <summary>Field number for the "records" field.</summary>
    public const int RecordsFieldNumber = 13;
    private static readonly pb::FieldCodec<global::G2Rail.Protobuf.PriceDetail> _repeated_records_codec
        = pb::FieldCodec.ForMessage(106, global::G2Rail.Protobuf.PriceDetail.Parser);
    private readonly pbc::RepeatedField<global::G2Rail.Protobuf.PriceDetail> records_ = new pbc::RepeatedField<global::G2Rail.Protobuf.PriceDetail>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::G2Rail.Protobuf.PriceDetail> Records {
      get { return records_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as OnlineOrderResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(OnlineOrderResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Loading != other.Loading) return false;
      if (OfflineFulfillment != other.OfflineFulfillment) return false;
      if (TrainDescription != other.TrainDescription) return false;
      if (!object.Equals(Railway, other.Railway)) return false;
      if (!object.Equals(From, other.From)) return false;
      if (!object.Equals(To, other.To)) return false;
      if (Departure != other.Departure) return false;
      if (Arrival != other.Arrival) return false;
      if (!object.Equals(TicketPrice, other.TicketPrice)) return false;
      if (!object.Equals(PaymentPrice, other.PaymentPrice)) return false;
      if (!object.Equals(ChargingPrice, other.ChargingPrice)) return false;
      if (!object.Equals(RebateAmount, other.RebateAmount)) return false;
      if(!trains_.Equals(other.trains_)) return false;
      if(!passengers_.Equals(other.passengers_)) return false;
      if(!tickets_.Equals(other.tickets_)) return false;
      if(!records_.Equals(other.records_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (Loading != false) hash ^= Loading.GetHashCode();
      if (OfflineFulfillment != false) hash ^= OfflineFulfillment.GetHashCode();
      if (TrainDescription.Length != 0) hash ^= TrainDescription.GetHashCode();
      if (railway_ != null) hash ^= Railway.GetHashCode();
      if (from_ != null) hash ^= From.GetHashCode();
      if (to_ != null) hash ^= To.GetHashCode();
      if (Departure.Length != 0) hash ^= Departure.GetHashCode();
      if (Arrival.Length != 0) hash ^= Arrival.GetHashCode();
      if (ticketPrice_ != null) hash ^= TicketPrice.GetHashCode();
      if (paymentPrice_ != null) hash ^= PaymentPrice.GetHashCode();
      if (chargingPrice_ != null) hash ^= ChargingPrice.GetHashCode();
      if (rebateAmount_ != null) hash ^= RebateAmount.GetHashCode();
      hash ^= trains_.GetHashCode();
      hash ^= passengers_.GetHashCode();
      hash ^= tickets_.GetHashCode();
      hash ^= records_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (railway_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Railway);
      }
      if (from_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(From);
      }
      if (to_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(To);
      }
      if (Departure.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Departure);
      }
      if (Arrival.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Arrival);
      }
      if (ticketPrice_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(TicketPrice);
      }
      if (paymentPrice_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(PaymentPrice);
      }
      if (chargingPrice_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(ChargingPrice);
      }
      if (rebateAmount_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(RebateAmount);
      }
      passengers_.WriteTo(output, _repeated_passengers_codec);
      tickets_.WriteTo(output, _repeated_tickets_codec);
      records_.WriteTo(output, _repeated_records_codec);
      if (Loading != false) {
        output.WriteRawTag(112);
        output.WriteBool(Loading);
      }
      if (OfflineFulfillment != false) {
        output.WriteRawTag(120);
        output.WriteBool(OfflineFulfillment);
      }
      if (TrainDescription.Length != 0) {
        output.WriteRawTag(130, 1);
        output.WriteString(TrainDescription);
      }
      trains_.WriteTo(output, _repeated_trains_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (Loading != false) {
        size += 1 + 1;
      }
      if (OfflineFulfillment != false) {
        size += 1 + 1;
      }
      if (TrainDescription.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(TrainDescription);
      }
      if (railway_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Railway);
      }
      if (from_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(From);
      }
      if (to_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(To);
      }
      if (Departure.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Departure);
      }
      if (Arrival.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Arrival);
      }
      if (ticketPrice_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TicketPrice);
      }
      if (paymentPrice_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PaymentPrice);
      }
      if (chargingPrice_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ChargingPrice);
      }
      if (rebateAmount_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RebateAmount);
      }
      size += trains_.CalculateSize(_repeated_trains_codec);
      size += passengers_.CalculateSize(_repeated_passengers_codec);
      size += tickets_.CalculateSize(_repeated_tickets_codec);
      size += records_.CalculateSize(_repeated_records_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(OnlineOrderResponse other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.Loading != false) {
        Loading = other.Loading;
      }
      if (other.OfflineFulfillment != false) {
        OfflineFulfillment = other.OfflineFulfillment;
      }
      if (other.TrainDescription.Length != 0) {
        TrainDescription = other.TrainDescription;
      }
      if (other.railway_ != null) {
        if (railway_ == null) {
          Railway = new global::G2Rail.Protobuf.Railway();
        }
        Railway.MergeFrom(other.Railway);
      }
      if (other.from_ != null) {
        if (from_ == null) {
          From = new global::G2Rail.Protobuf.Station();
        }
        From.MergeFrom(other.From);
      }
      if (other.to_ != null) {
        if (to_ == null) {
          To = new global::G2Rail.Protobuf.Station();
        }
        To.MergeFrom(other.To);
      }
      if (other.Departure.Length != 0) {
        Departure = other.Departure;
      }
      if (other.Arrival.Length != 0) {
        Arrival = other.Arrival;
      }
      if (other.ticketPrice_ != null) {
        if (ticketPrice_ == null) {
          TicketPrice = new global::G2Rail.Protobuf.Price();
        }
        TicketPrice.MergeFrom(other.TicketPrice);
      }
      if (other.paymentPrice_ != null) {
        if (paymentPrice_ == null) {
          PaymentPrice = new global::G2Rail.Protobuf.Price();
        }
        PaymentPrice.MergeFrom(other.PaymentPrice);
      }
      if (other.chargingPrice_ != null) {
        if (chargingPrice_ == null) {
          ChargingPrice = new global::G2Rail.Protobuf.Price();
        }
        ChargingPrice.MergeFrom(other.ChargingPrice);
      }
      if (other.rebateAmount_ != null) {
        if (rebateAmount_ == null) {
          RebateAmount = new global::G2Rail.Protobuf.Price();
        }
        RebateAmount.MergeFrom(other.RebateAmount);
      }
      trains_.Add(other.trains_);
      passengers_.Add(other.passengers_);
      tickets_.Add(other.tickets_);
      records_.Add(other.records_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Id = input.ReadString();
            break;
          }
          case 18: {
            if (railway_ == null) {
              Railway = new global::G2Rail.Protobuf.Railway();
            }
            input.ReadMessage(Railway);
            break;
          }
          case 26: {
            if (from_ == null) {
              From = new global::G2Rail.Protobuf.Station();
            }
            input.ReadMessage(From);
            break;
          }
          case 34: {
            if (to_ == null) {
              To = new global::G2Rail.Protobuf.Station();
            }
            input.ReadMessage(To);
            break;
          }
          case 42: {
            Departure = input.ReadString();
            break;
          }
          case 50: {
            Arrival = input.ReadString();
            break;
          }
          case 58: {
            if (ticketPrice_ == null) {
              TicketPrice = new global::G2Rail.Protobuf.Price();
            }
            input.ReadMessage(TicketPrice);
            break;
          }
          case 66: {
            if (paymentPrice_ == null) {
              PaymentPrice = new global::G2Rail.Protobuf.Price();
            }
            input.ReadMessage(PaymentPrice);
            break;
          }
          case 74: {
            if (chargingPrice_ == null) {
              ChargingPrice = new global::G2Rail.Protobuf.Price();
            }
            input.ReadMessage(ChargingPrice);
            break;
          }
          case 82: {
            if (rebateAmount_ == null) {
              RebateAmount = new global::G2Rail.Protobuf.Price();
            }
            input.ReadMessage(RebateAmount);
            break;
          }
          case 90: {
            passengers_.AddEntriesFrom(input, _repeated_passengers_codec);
            break;
          }
          case 98: {
            tickets_.AddEntriesFrom(input, _repeated_tickets_codec);
            break;
          }
          case 106: {
            records_.AddEntriesFrom(input, _repeated_records_codec);
            break;
          }
          case 112: {
            Loading = input.ReadBool();
            break;
          }
          case 120: {
            OfflineFulfillment = input.ReadBool();
            break;
          }
          case 130: {
            TrainDescription = input.ReadString();
            break;
          }
          case 138: {
            trains_.AddEntriesFrom(input, _repeated_trains_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
