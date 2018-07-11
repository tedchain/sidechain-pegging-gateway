// Copyright (c) 2010-2018 The Bitcoin developers.
// Original code was distributed under the MIT software license.
// Copyright (c) 2014-2018 TEDLab Sciences Ltd
// Tedchain code distributed under the GPLv3 license, see COPYING file.

#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Bitcoin.PaymentProtocol {

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class PaymentProtocolStructures {

    #region Descriptor
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PaymentProtocolStructures() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch9QYXltZW50UHJvdG9jb2xTdHJ1Y3R1cmVzLnByb3RvEghwYXltZW50cyIo", 
            "CgZPdXRwdXQSDgoGYW1vdW50GAEgASgEEg4KBnNjcmlwdBgCIAEoDCKdAQoO", 
            "UGF5bWVudERldGFpbHMSDwoHbmV0d29yaxgBIAEoCRIhCgdvdXRwdXRzGAIg", 
            "AygLMhAucGF5bWVudHMuT3V0cHV0EgwKBHRpbWUYAyABKAQSDwoHZXhwaXJl", 
            "cxgEIAEoBBIMCgRtZW1vGAUgASgJEhMKC3BheW1lbnRfdXJsGAYgASgJEhUK", 
            "DW1lcmNoYW50X2RhdGEYByABKAwijAEKDlBheW1lbnRSZXF1ZXN0Eh8KF3Bh", 
            "eW1lbnRfZGV0YWlsc192ZXJzaW9uGAEgASgNEhAKCHBraV90eXBlGAIgASgJ", 
            "EhAKCHBraV9kYXRhGAMgASgMEiIKGnNlcmlhbGl6ZWRfcGF5bWVudF9kZXRh", 
            "aWxzGAQgASgMEhEKCXNpZ25hdHVyZRgFIAEoDCInChBYNTA5Q2VydGlmaWNh", 
            "dGVzEhMKC2NlcnRpZmljYXRlGAEgAygMImkKB1BheW1lbnQSFQoNbWVyY2hh", 
            "bnRfZGF0YRgBIAEoDBIUCgx0cmFuc2FjdGlvbnMYAiADKAwSIwoJcmVmdW5k", 
            "X3RvGAMgAygLMhAucGF5bWVudHMuT3V0cHV0EgwKBG1lbW8YBCABKAkiPgoK", 
            "UGF5bWVudEFDSxIiCgdwYXltZW50GAEgASgLMhEucGF5bWVudHMuUGF5bWVu", 
            "dBIMCgRtZW1vGAIgASgJQigKHm9yZy5iaXRjb2luLnByb3RvY29scy5wYXlt", 
            "ZW50c0IGUHJvdG9zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedCodeInfo(null, new pbr::GeneratedCodeInfo[] {
            new pbr::GeneratedCodeInfo(typeof(global::Bitcoin.PaymentProtocol.Output), Output.Parser, new[]{ "Amount", "Script" }, null, null, null),
            new pbr::GeneratedCodeInfo(typeof(global::Bitcoin.PaymentProtocol.PaymentDetails), PaymentDetails.Parser, new[]{ "Network", "Outputs", "Time", "Expires", "Memo", "PaymentUrl", "MerchantData" }, null, null, null),
            new pbr::GeneratedCodeInfo(typeof(global::Bitcoin.PaymentProtocol.PaymentRequest), PaymentRequest.Parser, new[]{ "PaymentDetailsVersion", "PkiType", "PkiData", "SerializedPaymentDetails", "Signature" }, null, null, null),
            new pbr::GeneratedCodeInfo(typeof(global::Bitcoin.PaymentProtocol.X509Certificates), X509Certificates.Parser, new[]{ "Certificate" }, null, null, null),
            new pbr::GeneratedCodeInfo(typeof(global::Bitcoin.PaymentProtocol.Payment), Payment.Parser, new[]{ "MerchantData", "Transactions", "RefundTo", "Memo" }, null, null, null),
            new pbr::GeneratedCodeInfo(typeof(global::Bitcoin.PaymentProtocol.PaymentACK), PaymentACK.Parser, new[]{ "Payment", "Memo" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class Output : pb::IMessage<Output> {
    private static readonly pb::MessageParser<Output> _parser = new pb::MessageParser<Output>(() => new Output());
    public static pb::MessageParser<Output> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Bitcoin.PaymentProtocol.PaymentProtocolStructures.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public Output() {
      OnConstruction();
    }

    partial void OnConstruction();

    public Output(Output other) : this() {
      amount_ = other.amount_;
      script_ = other.script_;
    }

    public Output Clone() {
      return new Output(this);
    }

    public const int AmountFieldNumber = 1;
    private ulong amount_;
    public ulong Amount {
      get { return amount_; }
      set {
        amount_ = value;
      }
    }

    public const int ScriptFieldNumber = 2;
    private pb::ByteString script_ = pb::ByteString.Empty;
    public pb::ByteString Script {
      get { return script_; }
      set {
        script_ = pb::Preconditions.CheckNotNull(value, "value");
      }
    }

    public override bool Equals(object other) {
      return Equals(other as Output);
    }

    public bool Equals(Output other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Amount != other.Amount) return false;
      if (Script != other.Script) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Amount != 0UL) hash ^= Amount.GetHashCode();
      if (Script.Length != 0) hash ^= Script.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.Default.Format(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Amount != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(Amount);
      }
      if (Script.Length != 0) {
        output.WriteRawTag(18);
        output.WriteBytes(Script);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Amount != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Amount);
      }
      if (Script.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Script);
      }
      return size;
    }

    public void MergeFrom(Output other) {
      if (other == null) {
        return;
      }
      if (other.Amount != 0UL) {
        Amount = other.Amount;
      }
      if (other.Script.Length != 0) {
        Script = other.Script;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Amount = input.ReadUInt64();
            break;
          }
          case 18: {
            Script = input.ReadBytes();
            break;
          }
        }
      }
    }

  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class PaymentDetails : pb::IMessage<PaymentDetails> {
    private static readonly pb::MessageParser<PaymentDetails> _parser = new pb::MessageParser<PaymentDetails>(() => new PaymentDetails());
    public static pb::MessageParser<PaymentDetails> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Bitcoin.PaymentProtocol.PaymentProtocolStructures.Descriptor.MessageTypes[1]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public PaymentDetails() {
      OnConstruction();
    }

    partial void OnConstruction();

    public PaymentDetails(PaymentDetails other) : this() {
      network_ = other.network_;
      outputs_ = other.outputs_.Clone();
      time_ = other.time_;
      expires_ = other.expires_;
      memo_ = other.memo_;
      paymentUrl_ = other.paymentUrl_;
      merchantData_ = other.merchantData_;
    }

    public PaymentDetails Clone() {
      return new PaymentDetails(this);
    }

    public const int NetworkFieldNumber = 1;
    private string network_ = "";
    public string Network {
      get { return network_; }
      set {
        network_ = pb::Preconditions.CheckNotNull(value, "value");
      }
    }

    public const int OutputsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Bitcoin.PaymentProtocol.Output> _repeated_outputs_codec
        = pb::FieldCodec.ForMessage(18, global::Bitcoin.PaymentProtocol.Output.Parser);
    private readonly pbc::RepeatedField<global::Bitcoin.PaymentProtocol.Output> outputs_ = new pbc::RepeatedField<global::Bitcoin.PaymentProtocol.Output>();
    public pbc::RepeatedField<global::Bitcoin.PaymentProtocol.Output> Outputs {
      get { return outputs_; }
    }

    public const int TimeFieldNumber = 3;
    private ulong time_;
    public ulong Time {
      get { return time_; }
      set {
        time_ = value;
      }
    }

    public const int ExpiresFieldNumber = 4;
    private ulong expires_;
    public ulong Expires {
      get { return expires_; }
      set {
        expires_ = value;
      }
    }

    public const int MemoFieldNumber = 5;
    private string memo_ = "";
    public string Memo {
      get { return memo_; }
      set {
        memo_ = pb::Preconditions.CheckNotNull(value, "value");
      }
    }

    public const int PaymentUrlFieldNumber = 6;
    private string paymentUrl_ = "";
    public string PaymentUrl {
      get { return paymentUrl_; }
      set {
        paymentUrl_ = pb::Preconditions.CheckNotNull(value, "value");
      }
    }

    public const int MerchantDataFieldNumber = 7;
    private pb::ByteString merchantData_ = pb::ByteString.Empty;
    public pb::ByteString MerchantData {
      get { return merchantData_; }
      set {
        merchantData_ = pb::Preconditions.CheckNotNull(value, "value");
      }
    }

    public override bool Equals(object other) {
      return Equals(other as PaymentDetails);
    }

    public bool Equals(PaymentDetails other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Network != other.Network) return false;
      if(!outputs_.Equals(other.outputs_)) return false;
      if (Time != other.Time) return false;
      if (Expires != other.Expires) return false;
      if (Memo != other.Memo) return false;
      if (PaymentUrl != other.PaymentUrl) return false;
      if (MerchantData != other.MerchantData) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Network.Length != 0) hash ^= Network.GetHashCode();
      hash ^= outputs_.GetHashCode();
      if (Time != 0UL) hash ^= Time.GetHashCode();
      if (Expires != 0UL) hash ^= Expires.GetHashCode();
      if (Memo.Length != 0) hash ^= Memo.GetHashCode();
      if (PaymentUrl.Length != 0) hash ^= PaymentUrl.GetHashCode();
      if (MerchantData.Length != 0) hash ^= MerchantData.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.Default.Format(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Network.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Network);
      }
      outputs_.WriteTo(output, _repeated_outputs_codec);
      if (Time != 0UL) {
        output.WriteRawTag(24);
        output.WriteUInt64(Time);
      }
      if (Expires != 0UL) {
        output.WriteRawTag(32);
        output.WriteUInt64(Expires);
      }
      if (Memo.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Memo);
      }
      if (PaymentUrl.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(PaymentUrl);
      }
      if (MerchantData.Length != 0) {
        output.WriteRawTag(58);
        output.WriteBytes(MerchantData);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Network.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Network);
      }
      size += outputs_.CalculateSize(_repeated_outputs_codec);
      if (Time != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Time);
      }
      if (Expires != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Expires);
      }
      if (Memo.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Memo);
      }
      if (PaymentUrl.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PaymentUrl);
      }
      if (MerchantData.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(MerchantData);
      }
      return size;
    }

    public void MergeFrom(PaymentDetails other) {
      if (other == null) {
        return;
      }
      if (other.Network.Length != 0) {
        Network = other.Network;
      }
      outputs_.Add(other.outputs_);
      if (other.Time != 0UL) {
        Time = other.Time;
      }
      if (other.Expires != 0UL) {
        Expires = other.Expires;
      }
      if (other.Memo.Length != 0) {
        Memo = other.Memo;
      }
      if (other.PaymentUrl.Length != 0) {
        PaymentUrl = other.PaymentUrl;
      }
      if (other.MerchantData.Length != 0) {
        MerchantData = other.MerchantData;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Network = input.ReadString();
            break;
          }
          case 18: {
            outputs_.AddEntriesFrom(input, _repeated_outputs_codec);
            break;
          }
          case 24: {
            Time = input.ReadUInt64();
            break;
          }
          case 32: {
            Expires = input.ReadUInt64();
            break;
          }
          case 42: {
            Memo = input.ReadString();
            break;
          }
          case 50: {
            PaymentUrl = input.ReadString();
            break;
          }
          case 58: {
            MerchantData = input.ReadBytes();
            break;
          }
        }
      }
    }

  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class PaymentRequest : pb::IMessage<PaymentRequest> {
    private static readonly pb::MessageParser<PaymentRequest> _parser = new pb::MessageParser<PaymentRequest>(() => new PaymentRequest());
    public static pb::MessageParser<PaymentRequest> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Bitcoin.PaymentProtocol.PaymentProtocolStructures.Descriptor.MessageTypes[2]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public PaymentRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    public PaymentRequest(PaymentRequest other) : this() {
      paymentDetailsVersion_ = other.paymentDetailsVersion_;
      pkiType_ = other.pkiType_;
      pkiData_ = other.pkiData_;
      serializedPaymentDetails_ = other.serializedPaymentDetails_;
      signature_ = other.signature_;
    }

    public PaymentRequest Clone() {
      return new PaymentRequest(this);
    }

    public const int PaymentDetailsVersionFieldNumber = 1;
    private uint paymentDetailsVersion_;
    public uint PaymentDetailsVersion {
      get { return paymentDetailsVersion_; }
      set {
        paymentDetailsVersion_ = value;
      }
    }

    public const int PkiTypeFieldNumber = 2;
    private string pkiType_ = "";
    public string PkiType {
      get { return pkiType_; }
      set {
        pkiType_ = pb::Preconditions.CheckNotNull(value, "value");
      }
    }

    public const int PkiDataFieldNumber = 3;
    private pb::ByteString pkiData_ = pb::ByteString.Empty;
    public pb::ByteString PkiData {
      get { return pkiData_; }
      set {
        pkiData_ = pb::Preconditions.CheckNotNull(value, "value");
      }
    }

    public const int SerializedPaymentDetailsFieldNumber = 4;
    private pb::ByteString serializedPaymentDetails_ = pb::ByteString.Empty;
    public pb::ByteString SerializedPaymentDetails {
      get { return serializedPaymentDetails_; }
      set {
        serializedPaymentDetails_ = pb::Preconditions.CheckNotNull(value, "value");
      }
    }

    public const int SignatureFieldNumber = 5;
    private pb::ByteString signature_ = pb::ByteString.Empty;
    public pb::ByteString Signature {
      get { return signature_; }
      set {
        signature_ = pb::Preconditions.CheckNotNull(value, "value");
      }
    }

    public override bool Equals(object other) {
      return Equals(other as PaymentRequest);
    }

    public bool Equals(PaymentRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PaymentDetailsVersion != other.PaymentDetailsVersion) return false;
      if (PkiType != other.PkiType) return false;
      if (PkiData != other.PkiData) return false;
      if (SerializedPaymentDetails != other.SerializedPaymentDetails) return false;
      if (Signature != other.Signature) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (PaymentDetailsVersion != 0) hash ^= PaymentDetailsVersion.GetHashCode();
      if (PkiType.Length != 0) hash ^= PkiType.GetHashCode();
      if (PkiData.Length != 0) hash ^= PkiData.GetHashCode();
      if (SerializedPaymentDetails.Length != 0) hash ^= SerializedPaymentDetails.GetHashCode();
      if (Signature.Length != 0) hash ^= Signature.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.Default.Format(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (PaymentDetailsVersion != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(PaymentDetailsVersion);
      }
      if (PkiType.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(PkiType);
      }
      if (PkiData.Length != 0) {
        output.WriteRawTag(26);
        output.WriteBytes(PkiData);
      }
      if (SerializedPaymentDetails.Length != 0) {
        output.WriteRawTag(34);
        output.WriteBytes(SerializedPaymentDetails);
      }
      if (Signature.Length != 0) {
        output.WriteRawTag(42);
        output.WriteBytes(Signature);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (PaymentDetailsVersion != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(PaymentDetailsVersion);
      }
      if (PkiType.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PkiType);
      }
      if (PkiData.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(PkiData);
      }
      if (SerializedPaymentDetails.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(SerializedPaymentDetails);
      }
      if (Signature.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Signature);
      }
      return size;
    }

    public void MergeFrom(PaymentRequest other) {
      if (other == null) {
        return;
      }
      if (other.PaymentDetailsVersion != 0) {
        PaymentDetailsVersion = other.PaymentDetailsVersion;
      }
      if (other.PkiType.Length != 0) {
        PkiType = other.PkiType;
      }
      if (other.PkiData.Length != 0) {
        PkiData = other.PkiData;
      }
      if (other.SerializedPaymentDetails.Length != 0) {
        SerializedPaymentDetails = other.SerializedPaymentDetails;
      }
      if (other.Signature.Length != 0) {
        Signature = other.Signature;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            PaymentDetailsVersion = input.ReadUInt32();
            break;
          }
          case 18: {
            PkiType = input.ReadString();
            break;
          }
          case 26: {
            PkiData = input.ReadBytes();
            break;
          }
          case 34: {
            SerializedPaymentDetails = input.ReadBytes();
            break;
          }
          case 42: {
            Signature = input.ReadBytes();
            break;
          }
        }
      }
    }

  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class X509Certificates : pb::IMessage<X509Certificates> {
    private static readonly pb::MessageParser<X509Certificates> _parser = new pb::MessageParser<X509Certificates>(() => new X509Certificates());
    public static pb::MessageParser<X509Certificates> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Bitcoin.PaymentProtocol.PaymentProtocolStructures.Descriptor.MessageTypes[3]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public X509Certificates() {
      OnConstruction();
    }

    partial void OnConstruction();

    public X509Certificates(X509Certificates other) : this() {
      certificate_ = other.certificate_.Clone();
    }

    public X509Certificates Clone() {
      return new X509Certificates(this);
    }

    public const int CertificateFieldNumber = 1;
    private static readonly pb::FieldCodec<pb::ByteString> _repeated_certificate_codec
        = pb::FieldCodec.ForBytes(10);
    private readonly pbc::RepeatedField<pb::ByteString> certificate_ = new pbc::RepeatedField<pb::ByteString>();
    public pbc::RepeatedField<pb::ByteString> Certificate {
      get { return certificate_; }
    }

    public override bool Equals(object other) {
      return Equals(other as X509Certificates);
    }

    public bool Equals(X509Certificates other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!certificate_.Equals(other.certificate_)) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      hash ^= certificate_.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.Default.Format(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      certificate_.WriteTo(output, _repeated_certificate_codec);
    }

    public int CalculateSize() {
      int size = 0;
      size += certificate_.CalculateSize(_repeated_certificate_codec);
      return size;
    }

    public void MergeFrom(X509Certificates other) {
      if (other == null) {
        return;
      }
      certificate_.Add(other.certificate_);
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            certificate_.AddEntriesFrom(input, _repeated_certificate_codec);
            break;
          }
        }
      }
    }

  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class Payment : pb::IMessage<Payment> {
    private static readonly pb::MessageParser<Payment> _parser = new pb::MessageParser<Payment>(() => new Payment());
    public static pb::MessageParser<Payment> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Bitcoin.PaymentProtocol.PaymentProtocolStructures.Descriptor.MessageTypes[4]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public Payment() {
      OnConstruction();
    }

    partial void OnConstruction();

    public Payment(Payment other) : this() {
      merchantData_ = other.merchantData_;
      transactions_ = other.transactions_.Clone();
      refundTo_ = other.refundTo_.Clone();
      memo_ = other.memo_;
    }

    public Payment Clone() {
      return new Payment(this);
    }

    public const int MerchantDataFieldNumber = 1;
    private pb::ByteString merchantData_ = pb::ByteString.Empty;
    public pb::ByteString MerchantData {
      get { return merchantData_; }
      set {
        merchantData_ = pb::Preconditions.CheckNotNull(value, "value");
      }
    }

    public const int TransactionsFieldNumber = 2;
    private static readonly pb::FieldCodec<pb::ByteString> _repeated_transactions_codec
        = pb::FieldCodec.ForBytes(18);
    private readonly pbc::RepeatedField<pb::ByteString> transactions_ = new pbc::RepeatedField<pb::ByteString>();
    public pbc::RepeatedField<pb::ByteString> Transactions {
      get { return transactions_; }
    }

    public const int RefundToFieldNumber = 3;
    private static readonly pb::FieldCodec<global::Bitcoin.PaymentProtocol.Output> _repeated_refundTo_codec
        = pb::FieldCodec.ForMessage(26, global::Bitcoin.PaymentProtocol.Output.Parser);
    private readonly pbc::RepeatedField<global::Bitcoin.PaymentProtocol.Output> refundTo_ = new pbc::RepeatedField<global::Bitcoin.PaymentProtocol.Output>();
    public pbc::RepeatedField<global::Bitcoin.PaymentProtocol.Output> RefundTo {
      get { return refundTo_; }
    }

    public const int MemoFieldNumber = 4;
    private string memo_ = "";
    public string Memo {
      get { return memo_; }
      set {
        memo_ = pb::Preconditions.CheckNotNull(value, "value");
      }
    }

    public override bool Equals(object other) {
      return Equals(other as Payment);
    }

    public bool Equals(Payment other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (MerchantData != other.MerchantData) return false;
      if(!transactions_.Equals(other.transactions_)) return false;
      if(!refundTo_.Equals(other.refundTo_)) return false;
      if (Memo != other.Memo) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (MerchantData.Length != 0) hash ^= MerchantData.GetHashCode();
      hash ^= transactions_.GetHashCode();
      hash ^= refundTo_.GetHashCode();
      if (Memo.Length != 0) hash ^= Memo.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.Default.Format(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (MerchantData.Length != 0) {
        output.WriteRawTag(10);
        output.WriteBytes(MerchantData);
      }
      transactions_.WriteTo(output, _repeated_transactions_codec);
      refundTo_.WriteTo(output, _repeated_refundTo_codec);
      if (Memo.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Memo);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (MerchantData.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(MerchantData);
      }
      size += transactions_.CalculateSize(_repeated_transactions_codec);
      size += refundTo_.CalculateSize(_repeated_refundTo_codec);
      if (Memo.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Memo);
      }
      return size;
    }

    public void MergeFrom(Payment other) {
      if (other == null) {
        return;
      }
      if (other.MerchantData.Length != 0) {
        MerchantData = other.MerchantData;
      }
      transactions_.Add(other.transactions_);
      refundTo_.Add(other.refundTo_);
      if (other.Memo.Length != 0) {
        Memo = other.Memo;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            MerchantData = input.ReadBytes();
            break;
          }
          case 18: {
            transactions_.AddEntriesFrom(input, _repeated_transactions_codec);
            break;
          }
          case 26: {
            refundTo_.AddEntriesFrom(input, _repeated_refundTo_codec);
            break;
          }
          case 34: {
            Memo = input.ReadString();
            break;
          }
        }
      }
    }

  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class PaymentACK : pb::IMessage<PaymentACK> {
    private static readonly pb::MessageParser<PaymentACK> _parser = new pb::MessageParser<PaymentACK>(() => new PaymentACK());
    public static pb::MessageParser<PaymentACK> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Bitcoin.PaymentProtocol.PaymentProtocolStructures.Descriptor.MessageTypes[5]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public PaymentACK() {
      OnConstruction();
    }

    partial void OnConstruction();

    public PaymentACK(PaymentACK other) : this() {
      Payment = other.payment_ != null ? other.Payment.Clone() : null;
      memo_ = other.memo_;
    }

    public PaymentACK Clone() {
      return new PaymentACK(this);
    }

    public const int PaymentFieldNumber = 1;
    private global::Bitcoin.PaymentProtocol.Payment payment_;
    public global::Bitcoin.PaymentProtocol.Payment Payment {
      get { return payment_; }
      set {
        payment_ = value;
      }
    }

    public const int MemoFieldNumber = 2;
    private string memo_ = "";
    public string Memo {
      get { return memo_; }
      set {
        memo_ = pb::Preconditions.CheckNotNull(value, "value");
      }
    }

    public override bool Equals(object other) {
      return Equals(other as PaymentACK);
    }

    public bool Equals(PaymentACK other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Payment, other.Payment)) return false;
      if (Memo != other.Memo) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (payment_ != null) hash ^= Payment.GetHashCode();
      if (Memo.Length != 0) hash ^= Memo.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.Default.Format(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (payment_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Payment);
      }
      if (Memo.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Memo);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (payment_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Payment);
      }
      if (Memo.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Memo);
      }
      return size;
    }

    public void MergeFrom(PaymentACK other) {
      if (other == null) {
        return;
      }
      if (other.payment_ != null) {
        if (payment_ == null) {
          payment_ = new global::Bitcoin.PaymentProtocol.Payment();
        }
        Payment.MergeFrom(other.Payment);
      }
      if (other.Memo.Length != 0) {
        Memo = other.Memo;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            if (payment_ == null) {
              payment_ = new global::Bitcoin.PaymentProtocol.Payment();
            }
            input.ReadMessage(payment_);
            break;
          }
          case 18: {
            Memo = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
