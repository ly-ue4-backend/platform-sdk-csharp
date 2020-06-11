// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: github.com/improbable-io/go-proto-logfields/logfields.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Improbable {

  /// <summary>Holder for reflection information generated from github.com/improbable-io/go-proto-logfields/logfields.proto</summary>
  public static partial class LogfieldsReflection {

    #region Descriptor
    /// <summary>File descriptor for github.com/improbable-io/go-proto-logfields/logfields.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LogfieldsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjtnaXRodWIuY29tL2ltcHJvYmFibGUtaW8vZ28tcHJvdG8tbG9nZmllbGRz",
            "L2xvZ2ZpZWxkcy5wcm90bxIKaW1wcm9iYWJsZRogZ29vZ2xlL3Byb3RvYnVm",
            "L2Rlc2NyaXB0b3IucHJvdG8iGAoITG9nRmllbGQSDAoEbmFtZRgBIAEoCTpH",
            "Cghsb2dmaWVsZBIdLmdvb2dsZS5wcm90b2J1Zi5GaWVsZE9wdGlvbnMYtOUD",
            "IAEoCzIULmltcHJvYmFibGUuTG9nRmllbGRCC1oJbG9nZmllbGRzYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.Reflection.DescriptorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pb::Extension[] { LogfieldsExtensions.Logfield }, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Improbable.LogField), global::Improbable.LogField.Parser, new[]{ "Name" }, null, null, null, null)
          }));
    }
    #endregion

  }
  /// <summary>Holder for extension identifiers generated from the top level of github.com/improbable-io/go-proto-logfields/logfields.proto</summary>
  public static partial class LogfieldsExtensions {
    /// <summary>
    /// logfield indicates if and how the annotated field should be included as
    /// context in log messages. This applies when a log message is generated
    /// while processing a proto message that contains the field (directly or via
    /// an embedded message).
    /// </summary>
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, global::Improbable.LogField> Logfield =
      new pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, global::Improbable.LogField>(62132, pb::FieldCodec.ForMessage(497058, global::Improbable.LogField.Parser));
  }

  #region Messages
  public sealed partial class LogField : pb::IMessage<LogField> {
    private static readonly pb::MessageParser<LogField> _parser = new pb::MessageParser<LogField>(() => new LogField());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<LogField> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Improbable.LogfieldsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LogField() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LogField(LogField other) : this() {
      name_ = other.name_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LogField Clone() {
      return new LogField(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// name of the log context field where the value of this field should be
    /// recorded. Fields with empty names are ignored.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as LogField);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(LogField other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(LogField other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
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
            Name = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code