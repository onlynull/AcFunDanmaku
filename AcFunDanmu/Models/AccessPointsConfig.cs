// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: AccessPointsConfig.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace AcFunDanmu {

  /// <summary>Holder for reflection information generated from AccessPointsConfig.proto</summary>
  public static partial class AccessPointsConfigReflection {

    #region Descriptor
    /// <summary>File descriptor for AccessPointsConfig.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AccessPointsConfigReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChhBY2Nlc3NQb2ludHNDb25maWcucHJvdG8SCkFjRnVuRGFubXUaEUFjY2Vz",
            "c1BvaW50LnByb3RvIr0BChJBY2Nlc3NQb2ludHNDb25maWcSKwoKb3B0aW1h",
            "bEFwcxgBIAMoCzIXLkFjRnVuRGFubXUuQWNjZXNzUG9pbnQSKgoJYmFja3Vw",
            "QXBzGAIgAygLMhcuQWNGdW5EYW5tdS5BY2Nlc3NQb2ludBIWCg5hdmFpbGFi",
            "bGVQb3J0cxgDIAMoDRI2ChVmb3JlY2VMYXN0Q29ubmVjdGVkQXAYBCABKAsy",
            "Fy5BY0Z1bkRhbm11LkFjY2Vzc1BvaW50YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::AcFunDanmu.AccessPointReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::AcFunDanmu.AccessPointsConfig), global::AcFunDanmu.AccessPointsConfig.Parser, new[]{ "OptimalAps", "BackupAps", "AvailablePorts", "ForeceLastConnectedAp" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AccessPointsConfig : pb::IMessage<AccessPointsConfig> {
    private static readonly pb::MessageParser<AccessPointsConfig> _parser = new pb::MessageParser<AccessPointsConfig>(() => new AccessPointsConfig());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AccessPointsConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::AcFunDanmu.AccessPointsConfigReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AccessPointsConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AccessPointsConfig(AccessPointsConfig other) : this() {
      optimalAps_ = other.optimalAps_.Clone();
      backupAps_ = other.backupAps_.Clone();
      availablePorts_ = other.availablePorts_.Clone();
      foreceLastConnectedAp_ = other.foreceLastConnectedAp_ != null ? other.foreceLastConnectedAp_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AccessPointsConfig Clone() {
      return new AccessPointsConfig(this);
    }

    /// <summary>Field number for the "optimalAps" field.</summary>
    public const int OptimalApsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::AcFunDanmu.AccessPoint> _repeated_optimalAps_codec
        = pb::FieldCodec.ForMessage(10, global::AcFunDanmu.AccessPoint.Parser);
    private readonly pbc::RepeatedField<global::AcFunDanmu.AccessPoint> optimalAps_ = new pbc::RepeatedField<global::AcFunDanmu.AccessPoint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::AcFunDanmu.AccessPoint> OptimalAps {
      get { return optimalAps_; }
    }

    /// <summary>Field number for the "backupAps" field.</summary>
    public const int BackupApsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::AcFunDanmu.AccessPoint> _repeated_backupAps_codec
        = pb::FieldCodec.ForMessage(18, global::AcFunDanmu.AccessPoint.Parser);
    private readonly pbc::RepeatedField<global::AcFunDanmu.AccessPoint> backupAps_ = new pbc::RepeatedField<global::AcFunDanmu.AccessPoint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::AcFunDanmu.AccessPoint> BackupAps {
      get { return backupAps_; }
    }

    /// <summary>Field number for the "availablePorts" field.</summary>
    public const int AvailablePortsFieldNumber = 3;
    private static readonly pb::FieldCodec<uint> _repeated_availablePorts_codec
        = pb::FieldCodec.ForUInt32(26);
    private readonly pbc::RepeatedField<uint> availablePorts_ = new pbc::RepeatedField<uint>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<uint> AvailablePorts {
      get { return availablePorts_; }
    }

    /// <summary>Field number for the "foreceLastConnectedAp" field.</summary>
    public const int ForeceLastConnectedApFieldNumber = 4;
    private global::AcFunDanmu.AccessPoint foreceLastConnectedAp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::AcFunDanmu.AccessPoint ForeceLastConnectedAp {
      get { return foreceLastConnectedAp_; }
      set {
        foreceLastConnectedAp_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AccessPointsConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AccessPointsConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!optimalAps_.Equals(other.optimalAps_)) return false;
      if(!backupAps_.Equals(other.backupAps_)) return false;
      if(!availablePorts_.Equals(other.availablePorts_)) return false;
      if (!object.Equals(ForeceLastConnectedAp, other.ForeceLastConnectedAp)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= optimalAps_.GetHashCode();
      hash ^= backupAps_.GetHashCode();
      hash ^= availablePorts_.GetHashCode();
      if (foreceLastConnectedAp_ != null) hash ^= ForeceLastConnectedAp.GetHashCode();
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
      optimalAps_.WriteTo(output, _repeated_optimalAps_codec);
      backupAps_.WriteTo(output, _repeated_backupAps_codec);
      availablePorts_.WriteTo(output, _repeated_availablePorts_codec);
      if (foreceLastConnectedAp_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(ForeceLastConnectedAp);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += optimalAps_.CalculateSize(_repeated_optimalAps_codec);
      size += backupAps_.CalculateSize(_repeated_backupAps_codec);
      size += availablePorts_.CalculateSize(_repeated_availablePorts_codec);
      if (foreceLastConnectedAp_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ForeceLastConnectedAp);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AccessPointsConfig other) {
      if (other == null) {
        return;
      }
      optimalAps_.Add(other.optimalAps_);
      backupAps_.Add(other.backupAps_);
      availablePorts_.Add(other.availablePorts_);
      if (other.foreceLastConnectedAp_ != null) {
        if (foreceLastConnectedAp_ == null) {
          ForeceLastConnectedAp = new global::AcFunDanmu.AccessPoint();
        }
        ForeceLastConnectedAp.MergeFrom(other.ForeceLastConnectedAp);
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
            optimalAps_.AddEntriesFrom(input, _repeated_optimalAps_codec);
            break;
          }
          case 18: {
            backupAps_.AddEntriesFrom(input, _repeated_backupAps_codec);
            break;
          }
          case 26:
          case 24: {
            availablePorts_.AddEntriesFrom(input, _repeated_availablePorts_codec);
            break;
          }
          case 34: {
            if (foreceLastConnectedAp_ == null) {
              ForeceLastConnectedAp = new global::AcFunDanmu.AccessPoint();
            }
            input.ReadMessage(ForeceLastConnectedAp);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
