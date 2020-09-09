// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ZtLiveCsEnterRoom.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AcFunDanmu {

  /// <summary>Holder for reflection information generated from ZtLiveCsEnterRoom.proto</summary>
  public static partial class ZtLiveCsEnterRoomReflection {

    #region Descriptor
    /// <summary>File descriptor for ZtLiveCsEnterRoom.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ZtLiveCsEnterRoomReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdadExpdmVDc0VudGVyUm9vbS5wcm90bxIKQWNGdW5EYW5tdSKLAQoRWnRM",
            "aXZlQ3NFbnRlclJvb20SEAoIaXNBdXRob3IYASABKAgSFgoOcmVjb25uZWN0",
            "Q291bnQYAiABKAUSFQoNbGFzdEVycm9yQ29kZRgDIAEoBRIXCg9lbnRlclJv",
            "b21BdHRhY2gYBCABKAkSHAoUY2xpZW50TGl2ZVNka1ZlcnNpb24YBSABKAki",
            "MwoUWnRMaXZlQ3NFbnRlclJvb21BY2sSGwoTaGVhcnRiZWF0SW50ZXJ2YWxN",
            "cxgBIAEoA2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AcFunDanmu.ZtLiveCsEnterRoom), global::AcFunDanmu.ZtLiveCsEnterRoom.Parser, new[]{ "IsAuthor", "ReconnectCount", "LastErrorCode", "EnterRoomAttach", "ClientLiveSdkVersion" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::AcFunDanmu.ZtLiveCsEnterRoomAck), global::AcFunDanmu.ZtLiveCsEnterRoomAck.Parser, new[]{ "HeartbeatIntervalMs" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ZtLiveCsEnterRoom : pb::IMessage<ZtLiveCsEnterRoom>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ZtLiveCsEnterRoom> _parser = new pb::MessageParser<ZtLiveCsEnterRoom>(() => new ZtLiveCsEnterRoom());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ZtLiveCsEnterRoom> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AcFunDanmu.ZtLiveCsEnterRoomReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ZtLiveCsEnterRoom() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ZtLiveCsEnterRoom(ZtLiveCsEnterRoom other) : this() {
      isAuthor_ = other.isAuthor_;
      reconnectCount_ = other.reconnectCount_;
      lastErrorCode_ = other.lastErrorCode_;
      enterRoomAttach_ = other.enterRoomAttach_;
      clientLiveSdkVersion_ = other.clientLiveSdkVersion_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ZtLiveCsEnterRoom Clone() {
      return new ZtLiveCsEnterRoom(this);
    }

    /// <summary>Field number for the "isAuthor" field.</summary>
    public const int IsAuthorFieldNumber = 1;
    private bool isAuthor_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsAuthor {
      get { return isAuthor_; }
      set {
        isAuthor_ = value;
      }
    }

    /// <summary>Field number for the "reconnectCount" field.</summary>
    public const int ReconnectCountFieldNumber = 2;
    private int reconnectCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ReconnectCount {
      get { return reconnectCount_; }
      set {
        reconnectCount_ = value;
      }
    }

    /// <summary>Field number for the "lastErrorCode" field.</summary>
    public const int LastErrorCodeFieldNumber = 3;
    private int lastErrorCode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int LastErrorCode {
      get { return lastErrorCode_; }
      set {
        lastErrorCode_ = value;
      }
    }

    /// <summary>Field number for the "enterRoomAttach" field.</summary>
    public const int EnterRoomAttachFieldNumber = 4;
    private string enterRoomAttach_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string EnterRoomAttach {
      get { return enterRoomAttach_; }
      set {
        enterRoomAttach_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "clientLiveSdkVersion" field.</summary>
    public const int ClientLiveSdkVersionFieldNumber = 5;
    private string clientLiveSdkVersion_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ClientLiveSdkVersion {
      get { return clientLiveSdkVersion_; }
      set {
        clientLiveSdkVersion_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ZtLiveCsEnterRoom);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ZtLiveCsEnterRoom other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsAuthor != other.IsAuthor) return false;
      if (ReconnectCount != other.ReconnectCount) return false;
      if (LastErrorCode != other.LastErrorCode) return false;
      if (EnterRoomAttach != other.EnterRoomAttach) return false;
      if (ClientLiveSdkVersion != other.ClientLiveSdkVersion) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (IsAuthor != false) hash ^= IsAuthor.GetHashCode();
      if (ReconnectCount != 0) hash ^= ReconnectCount.GetHashCode();
      if (LastErrorCode != 0) hash ^= LastErrorCode.GetHashCode();
      if (EnterRoomAttach.Length != 0) hash ^= EnterRoomAttach.GetHashCode();
      if (ClientLiveSdkVersion.Length != 0) hash ^= ClientLiveSdkVersion.GetHashCode();
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
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (IsAuthor != false) {
        output.WriteRawTag(8);
        output.WriteBool(IsAuthor);
      }
      if (ReconnectCount != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(ReconnectCount);
      }
      if (LastErrorCode != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(LastErrorCode);
      }
      if (EnterRoomAttach.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(EnterRoomAttach);
      }
      if (ClientLiveSdkVersion.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(ClientLiveSdkVersion);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (IsAuthor != false) {
        output.WriteRawTag(8);
        output.WriteBool(IsAuthor);
      }
      if (ReconnectCount != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(ReconnectCount);
      }
      if (LastErrorCode != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(LastErrorCode);
      }
      if (EnterRoomAttach.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(EnterRoomAttach);
      }
      if (ClientLiveSdkVersion.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(ClientLiveSdkVersion);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (IsAuthor != false) {
        size += 1 + 1;
      }
      if (ReconnectCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ReconnectCount);
      }
      if (LastErrorCode != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(LastErrorCode);
      }
      if (EnterRoomAttach.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(EnterRoomAttach);
      }
      if (ClientLiveSdkVersion.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ClientLiveSdkVersion);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ZtLiveCsEnterRoom other) {
      if (other == null) {
        return;
      }
      if (other.IsAuthor != false) {
        IsAuthor = other.IsAuthor;
      }
      if (other.ReconnectCount != 0) {
        ReconnectCount = other.ReconnectCount;
      }
      if (other.LastErrorCode != 0) {
        LastErrorCode = other.LastErrorCode;
      }
      if (other.EnterRoomAttach.Length != 0) {
        EnterRoomAttach = other.EnterRoomAttach;
      }
      if (other.ClientLiveSdkVersion.Length != 0) {
        ClientLiveSdkVersion = other.ClientLiveSdkVersion;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            IsAuthor = input.ReadBool();
            break;
          }
          case 16: {
            ReconnectCount = input.ReadInt32();
            break;
          }
          case 24: {
            LastErrorCode = input.ReadInt32();
            break;
          }
          case 34: {
            EnterRoomAttach = input.ReadString();
            break;
          }
          case 42: {
            ClientLiveSdkVersion = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            IsAuthor = input.ReadBool();
            break;
          }
          case 16: {
            ReconnectCount = input.ReadInt32();
            break;
          }
          case 24: {
            LastErrorCode = input.ReadInt32();
            break;
          }
          case 34: {
            EnterRoomAttach = input.ReadString();
            break;
          }
          case 42: {
            ClientLiveSdkVersion = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class ZtLiveCsEnterRoomAck : pb::IMessage<ZtLiveCsEnterRoomAck>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ZtLiveCsEnterRoomAck> _parser = new pb::MessageParser<ZtLiveCsEnterRoomAck>(() => new ZtLiveCsEnterRoomAck());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ZtLiveCsEnterRoomAck> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AcFunDanmu.ZtLiveCsEnterRoomReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ZtLiveCsEnterRoomAck() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ZtLiveCsEnterRoomAck(ZtLiveCsEnterRoomAck other) : this() {
      heartbeatIntervalMs_ = other.heartbeatIntervalMs_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ZtLiveCsEnterRoomAck Clone() {
      return new ZtLiveCsEnterRoomAck(this);
    }

    /// <summary>Field number for the "heartbeatIntervalMs" field.</summary>
    public const int HeartbeatIntervalMsFieldNumber = 1;
    private long heartbeatIntervalMs_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long HeartbeatIntervalMs {
      get { return heartbeatIntervalMs_; }
      set {
        heartbeatIntervalMs_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ZtLiveCsEnterRoomAck);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ZtLiveCsEnterRoomAck other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (HeartbeatIntervalMs != other.HeartbeatIntervalMs) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (HeartbeatIntervalMs != 0L) hash ^= HeartbeatIntervalMs.GetHashCode();
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
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (HeartbeatIntervalMs != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(HeartbeatIntervalMs);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (HeartbeatIntervalMs != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(HeartbeatIntervalMs);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (HeartbeatIntervalMs != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(HeartbeatIntervalMs);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ZtLiveCsEnterRoomAck other) {
      if (other == null) {
        return;
      }
      if (other.HeartbeatIntervalMs != 0L) {
        HeartbeatIntervalMs = other.HeartbeatIntervalMs;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            HeartbeatIntervalMs = input.ReadInt64();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            HeartbeatIntervalMs = input.ReadInt64();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code