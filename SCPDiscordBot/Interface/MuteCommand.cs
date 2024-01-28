// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: BotToPlugin/MuteCommand.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace SCPDiscord.Interface {

  /// <summary>Holder for reflection information generated from BotToPlugin/MuteCommand.proto</summary>
  public static partial class MuteCommandReflection {

    #region Descriptor
    /// <summary>File descriptor for BotToPlugin/MuteCommand.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MuteCommandReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ch1Cb3RUb1BsdWdpbi9NdXRlQ29tbWFuZC5wcm90bxIUU0NQRGlzY29yZC5J",
            "bnRlcmZhY2UijQEKC011dGVDb21tYW5kEhEKCWNoYW5uZWxJRBgBIAEoBBIP",
            "CgdzdGVhbUlEGAIgASgJEhAKCGR1cmF0aW9uGAMgASgJEg4KBnJlYXNvbhgE",
            "IAEoCRIQCghhZG1pblRhZxgFIAEoCRIPCgdhZG1pbklEGAYgASgEEhUKDWlu",
            "dGVyYWN0aW9uSUQYByABKARiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::SCPDiscord.Interface.MuteCommand), global::SCPDiscord.Interface.MuteCommand.Parser, new[]{ "ChannelID", "SteamID", "Duration", "Reason", "AdminTag", "AdminID", "InteractionID" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class MuteCommand : pb::IMessage<MuteCommand>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MuteCommand> _parser = new pb::MessageParser<MuteCommand>(() => new MuteCommand());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MuteCommand> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::SCPDiscord.Interface.MuteCommandReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MuteCommand() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MuteCommand(MuteCommand other) : this() {
      channelID_ = other.channelID_;
      steamID_ = other.steamID_;
      duration_ = other.duration_;
      reason_ = other.reason_;
      adminTag_ = other.adminTag_;
      adminID_ = other.adminID_;
      interactionID_ = other.interactionID_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MuteCommand Clone() {
      return new MuteCommand(this);
    }

    /// <summary>Field number for the "channelID" field.</summary>
    public const int ChannelIDFieldNumber = 1;
    private ulong channelID_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong ChannelID {
      get { return channelID_; }
      set {
        channelID_ = value;
      }
    }

    /// <summary>Field number for the "steamID" field.</summary>
    public const int SteamIDFieldNumber = 2;
    private string steamID_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string SteamID {
      get { return steamID_; }
      set {
        steamID_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "duration" field.</summary>
    public const int DurationFieldNumber = 3;
    private string duration_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Duration {
      get { return duration_; }
      set {
        duration_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "reason" field.</summary>
    public const int ReasonFieldNumber = 4;
    private string reason_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Reason {
      get { return reason_; }
      set {
        reason_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "adminTag" field.</summary>
    public const int AdminTagFieldNumber = 5;
    private string adminTag_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string AdminTag {
      get { return adminTag_; }
      set {
        adminTag_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "adminID" field.</summary>
    public const int AdminIDFieldNumber = 6;
    private ulong adminID_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong AdminID {
      get { return adminID_; }
      set {
        adminID_ = value;
      }
    }

    /// <summary>Field number for the "interactionID" field.</summary>
    public const int InteractionIDFieldNumber = 7;
    private ulong interactionID_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong InteractionID {
      get { return interactionID_; }
      set {
        interactionID_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MuteCommand);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MuteCommand other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ChannelID != other.ChannelID) return false;
      if (SteamID != other.SteamID) return false;
      if (Duration != other.Duration) return false;
      if (Reason != other.Reason) return false;
      if (AdminTag != other.AdminTag) return false;
      if (AdminID != other.AdminID) return false;
      if (InteractionID != other.InteractionID) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ChannelID != 0UL) hash ^= ChannelID.GetHashCode();
      if (SteamID.Length != 0) hash ^= SteamID.GetHashCode();
      if (Duration.Length != 0) hash ^= Duration.GetHashCode();
      if (Reason.Length != 0) hash ^= Reason.GetHashCode();
      if (AdminTag.Length != 0) hash ^= AdminTag.GetHashCode();
      if (AdminID != 0UL) hash ^= AdminID.GetHashCode();
      if (InteractionID != 0UL) hash ^= InteractionID.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (ChannelID != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(ChannelID);
      }
      if (SteamID.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(SteamID);
      }
      if (Duration.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Duration);
      }
      if (Reason.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Reason);
      }
      if (AdminTag.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(AdminTag);
      }
      if (AdminID != 0UL) {
        output.WriteRawTag(48);
        output.WriteUInt64(AdminID);
      }
      if (InteractionID != 0UL) {
        output.WriteRawTag(56);
        output.WriteUInt64(InteractionID);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ChannelID != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(ChannelID);
      }
      if (SteamID.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(SteamID);
      }
      if (Duration.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Duration);
      }
      if (Reason.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Reason);
      }
      if (AdminTag.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(AdminTag);
      }
      if (AdminID != 0UL) {
        output.WriteRawTag(48);
        output.WriteUInt64(AdminID);
      }
      if (InteractionID != 0UL) {
        output.WriteRawTag(56);
        output.WriteUInt64(InteractionID);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (ChannelID != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(ChannelID);
      }
      if (SteamID.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SteamID);
      }
      if (Duration.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Duration);
      }
      if (Reason.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Reason);
      }
      if (AdminTag.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(AdminTag);
      }
      if (AdminID != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(AdminID);
      }
      if (InteractionID != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(InteractionID);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MuteCommand other) {
      if (other == null) {
        return;
      }
      if (other.ChannelID != 0UL) {
        ChannelID = other.ChannelID;
      }
      if (other.SteamID.Length != 0) {
        SteamID = other.SteamID;
      }
      if (other.Duration.Length != 0) {
        Duration = other.Duration;
      }
      if (other.Reason.Length != 0) {
        Reason = other.Reason;
      }
      if (other.AdminTag.Length != 0) {
        AdminTag = other.AdminTag;
      }
      if (other.AdminID != 0UL) {
        AdminID = other.AdminID;
      }
      if (other.InteractionID != 0UL) {
        InteractionID = other.InteractionID;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
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
            ChannelID = input.ReadUInt64();
            break;
          }
          case 18: {
            SteamID = input.ReadString();
            break;
          }
          case 26: {
            Duration = input.ReadString();
            break;
          }
          case 34: {
            Reason = input.ReadString();
            break;
          }
          case 42: {
            AdminTag = input.ReadString();
            break;
          }
          case 48: {
            AdminID = input.ReadUInt64();
            break;
          }
          case 56: {
            InteractionID = input.ReadUInt64();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            ChannelID = input.ReadUInt64();
            break;
          }
          case 18: {
            SteamID = input.ReadString();
            break;
          }
          case 26: {
            Duration = input.ReadString();
            break;
          }
          case 34: {
            Reason = input.ReadString();
            break;
          }
          case 42: {
            AdminTag = input.ReadString();
            break;
          }
          case 48: {
            AdminID = input.ReadUInt64();
            break;
          }
          case 56: {
            InteractionID = input.ReadUInt64();
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
