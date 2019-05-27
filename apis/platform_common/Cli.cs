// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: cli.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Cli {

  /// <summary>Holder for reflection information generated from cli.proto</summary>
  public static partial class CliReflection {

    #region Descriptor
    /// <summary>File descriptor for cli.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CliReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgljbGkucHJvdG8SA2NsaRogZ29vZ2xlL3Byb3RvYnVmL2Rlc2NyaXB0b3Iu",
            "cHJvdG8iaAoHQ29tbWFuZBILCgN1c2UYASABKAkSDQoFc2hvcnQYAiABKAkS",
            "DAoEbG9uZxgDIAEoCRIPCgdleGFtcGxlGAQgASgJEhIKCmRlcHJlY2F0ZWQY",
            "BSABKAkSDgoGaGlkZGVuGAYgASgIIncKBEZsYWcSDAoEbmFtZRgBIAEoCRIR",
            "CglzaG9ydGhhbmQYAiABKAkSFQoNZGVmYXVsdF92YWx1ZRgDIAEoCRINCgV1",
            "c2FnZRgFIAEoCRIQCghyZXF1aXJlZBgGIAEoCBIWCg5pbmNsdWRlX25lc3Rl",
            "ZBgHIAEoCCIgCgdSZXF1ZXN0EhUKDWluY2x1ZGVfZW1wdHkYASABKAg6PwoH",
            "Y29tbWFuZBIeLmdvb2dsZS5wcm90b2J1Zi5NZXRob2RPcHRpb25zGP37AyAB",
            "KAsyDC5jbGkuQ29tbWFuZDo4CgRmbGFnEh0uZ29vZ2xlLnByb3RvYnVmLkZp",
            "ZWxkT3B0aW9ucxj9+wMgASgLMgkuY2xpLkZsYWc6QAoHcmVxdWVzdBIfLmdv",
            "b2dsZS5wcm90b2J1Zi5NZXNzYWdlT3B0aW9ucxj9+wMgASgLMgwuY2xpLlJl",
            "cXVlc3RCBVoDY2xpYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { pbr::FileDescriptor.DescriptorProtoFileDescriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Cli.Command), global::Cli.Command.Parser, new[]{ "Use", "Short", "Long", "Example", "Deprecated", "Hidden" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Cli.Flag), global::Cli.Flag.Parser, new[]{ "Name", "Shorthand", "DefaultValue", "Usage", "Required", "IncludeNested" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Cli.Request), global::Cli.Request.Parser, new[]{ "IncludeEmpty" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Command : pb::IMessage<Command> {
    private static readonly pb::MessageParser<Command> _parser = new pb::MessageParser<Command>(() => new Command());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Command> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Cli.CliReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Command() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Command(Command other) : this() {
      use_ = other.use_;
      short_ = other.short_;
      long_ = other.long_;
      example_ = other.example_;
      deprecated_ = other.deprecated_;
      hidden_ = other.hidden_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Command Clone() {
      return new Command(this);
    }

    /// <summary>Field number for the "use" field.</summary>
    public const int UseFieldNumber = 1;
    private string use_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Use {
      get { return use_; }
      set {
        use_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "short" field.</summary>
    public const int ShortFieldNumber = 2;
    private string short_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Short {
      get { return short_; }
      set {
        short_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "long" field.</summary>
    public const int LongFieldNumber = 3;
    private string long_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Long {
      get { return long_; }
      set {
        long_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "example" field.</summary>
    public const int ExampleFieldNumber = 4;
    private string example_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Example {
      get { return example_; }
      set {
        example_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "deprecated" field.</summary>
    public const int DeprecatedFieldNumber = 5;
    private string deprecated_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Deprecated {
      get { return deprecated_; }
      set {
        deprecated_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "hidden" field.</summary>
    public const int HiddenFieldNumber = 6;
    private bool hidden_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Hidden {
      get { return hidden_; }
      set {
        hidden_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Command);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Command other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Use != other.Use) return false;
      if (Short != other.Short) return false;
      if (Long != other.Long) return false;
      if (Example != other.Example) return false;
      if (Deprecated != other.Deprecated) return false;
      if (Hidden != other.Hidden) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Use.Length != 0) hash ^= Use.GetHashCode();
      if (Short.Length != 0) hash ^= Short.GetHashCode();
      if (Long.Length != 0) hash ^= Long.GetHashCode();
      if (Example.Length != 0) hash ^= Example.GetHashCode();
      if (Deprecated.Length != 0) hash ^= Deprecated.GetHashCode();
      if (Hidden != false) hash ^= Hidden.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Use.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Use);
      }
      if (Short.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Short);
      }
      if (Long.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Long);
      }
      if (Example.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Example);
      }
      if (Deprecated.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Deprecated);
      }
      if (Hidden != false) {
        output.WriteRawTag(48);
        output.WriteBool(Hidden);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Use.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Use);
      }
      if (Short.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Short);
      }
      if (Long.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Long);
      }
      if (Example.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Example);
      }
      if (Deprecated.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Deprecated);
      }
      if (Hidden != false) {
        size += 1 + 1;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Command other) {
      if (other == null) {
        return;
      }
      if (other.Use.Length != 0) {
        Use = other.Use;
      }
      if (other.Short.Length != 0) {
        Short = other.Short;
      }
      if (other.Long.Length != 0) {
        Long = other.Long;
      }
      if (other.Example.Length != 0) {
        Example = other.Example;
      }
      if (other.Deprecated.Length != 0) {
        Deprecated = other.Deprecated;
      }
      if (other.Hidden != false) {
        Hidden = other.Hidden;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Use = input.ReadString();
            break;
          }
          case 18: {
            Short = input.ReadString();
            break;
          }
          case 26: {
            Long = input.ReadString();
            break;
          }
          case 34: {
            Example = input.ReadString();
            break;
          }
          case 42: {
            Deprecated = input.ReadString();
            break;
          }
          case 48: {
            Hidden = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// TODO: In some cases a proto message can be used for multiple different requests. For example, Deployment proto message
  /// TODO: is used for both CreateDeploymentRequest as well as UpdateDeploymentRequest. In these cases, we may need to add
  /// TODO: a mechanism that will allow to define different flags for different commands. This could be done by allowing
  /// TODO: an array of CLI flag definitions (repeated field) where each one could have a different 'commandContext' property
  /// TODO: which would correspond to the command name and allow to control the flags settings in different commands.
  /// </summary>
  public sealed partial class Flag : pb::IMessage<Flag> {
    private static readonly pb::MessageParser<Flag> _parser = new pb::MessageParser<Flag>(() => new Flag());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Flag> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Cli.CliReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Flag() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Flag(Flag other) : this() {
      name_ = other.name_;
      shorthand_ = other.shorthand_;
      defaultValue_ = other.defaultValue_;
      usage_ = other.usage_;
      required_ = other.required_;
      includeNested_ = other.includeNested_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Flag Clone() {
      return new Flag(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "shorthand" field.</summary>
    public const int ShorthandFieldNumber = 2;
    private string shorthand_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Shorthand {
      get { return shorthand_; }
      set {
        shorthand_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "default_value" field.</summary>
    public const int DefaultValueFieldNumber = 3;
    private string defaultValue_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DefaultValue {
      get { return defaultValue_; }
      set {
        defaultValue_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "usage" field.</summary>
    public const int UsageFieldNumber = 5;
    private string usage_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Usage {
      get { return usage_; }
      set {
        usage_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "required" field.</summary>
    public const int RequiredFieldNumber = 6;
    private bool required_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Required {
      get { return required_; }
      set {
        required_ = value;
      }
    }

    /// <summary>Field number for the "include_nested" field.</summary>
    public const int IncludeNestedFieldNumber = 7;
    private bool includeNested_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IncludeNested {
      get { return includeNested_; }
      set {
        includeNested_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Flag);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Flag other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (Shorthand != other.Shorthand) return false;
      if (DefaultValue != other.DefaultValue) return false;
      if (Usage != other.Usage) return false;
      if (Required != other.Required) return false;
      if (IncludeNested != other.IncludeNested) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Shorthand.Length != 0) hash ^= Shorthand.GetHashCode();
      if (DefaultValue.Length != 0) hash ^= DefaultValue.GetHashCode();
      if (Usage.Length != 0) hash ^= Usage.GetHashCode();
      if (Required != false) hash ^= Required.GetHashCode();
      if (IncludeNested != false) hash ^= IncludeNested.GetHashCode();
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
      if (Shorthand.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Shorthand);
      }
      if (DefaultValue.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(DefaultValue);
      }
      if (Usage.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Usage);
      }
      if (Required != false) {
        output.WriteRawTag(48);
        output.WriteBool(Required);
      }
      if (IncludeNested != false) {
        output.WriteRawTag(56);
        output.WriteBool(IncludeNested);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Shorthand.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Shorthand);
      }
      if (DefaultValue.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DefaultValue);
      }
      if (Usage.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Usage);
      }
      if (Required != false) {
        size += 1 + 1;
      }
      if (IncludeNested != false) {
        size += 1 + 1;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Flag other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Shorthand.Length != 0) {
        Shorthand = other.Shorthand;
      }
      if (other.DefaultValue.Length != 0) {
        DefaultValue = other.DefaultValue;
      }
      if (other.Usage.Length != 0) {
        Usage = other.Usage;
      }
      if (other.Required != false) {
        Required = other.Required;
      }
      if (other.IncludeNested != false) {
        IncludeNested = other.IncludeNested;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            Shorthand = input.ReadString();
            break;
          }
          case 26: {
            DefaultValue = input.ReadString();
            break;
          }
          case 42: {
            Usage = input.ReadString();
            break;
          }
          case 48: {
            Required = input.ReadBool();
            break;
          }
          case 56: {
            IncludeNested = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// This annotation can be added to a message when we want to import an empty request message from a different package.
  /// Since this is a very much a rare corner case, please consider this as a deprecated functionality which may be removed
  /// in the future.
  /// </summary>
  public sealed partial class Request : pb::IMessage<Request> {
    private static readonly pb::MessageParser<Request> _parser = new pb::MessageParser<Request>(() => new Request());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Request> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Cli.CliReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Request() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Request(Request other) : this() {
      includeEmpty_ = other.includeEmpty_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Request Clone() {
      return new Request(this);
    }

    /// <summary>Field number for the "include_empty" field.</summary>
    public const int IncludeEmptyFieldNumber = 1;
    private bool includeEmpty_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IncludeEmpty {
      get { return includeEmpty_; }
      set {
        includeEmpty_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Request);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Request other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IncludeEmpty != other.IncludeEmpty) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (IncludeEmpty != false) hash ^= IncludeEmpty.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (IncludeEmpty != false) {
        output.WriteRawTag(8);
        output.WriteBool(IncludeEmpty);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (IncludeEmpty != false) {
        size += 1 + 1;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Request other) {
      if (other == null) {
        return;
      }
      if (other.IncludeEmpty != false) {
        IncludeEmpty = other.IncludeEmpty;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            IncludeEmpty = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
