//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: CGAnimationRpc.proto
// Note: requires additional types generated from: PublicStruct.proto
namespace GenPB
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CGAnimationRpcCgPlayAsk")]
  public partial class CGAnimationRpcCgPlayAsk : global::ProtoBuf.IExtensible
  {
    public CGAnimationRpcCgPlayAsk() {}
    
    private int _CgId = (int)-1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"CgId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int CgId
    {
      get { return _CgId; }
      set { _CgId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CGAnimationRpcCgPlayReply")]
  public partial class CGAnimationRpcCgPlayReply : global::ProtoBuf.IExtensible
  {
    public CGAnimationRpcCgPlayReply() {}
    
    private int _Result = (int)-1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int Result
    {
      get { return _Result; }
      set { _Result = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CGAnimationRpcCgPlayNotifyNotify")]
  public partial class CGAnimationRpcCgPlayNotifyNotify : global::ProtoBuf.IExtensible
  {
    public CGAnimationRpcCgPlayNotifyNotify() {}
    
    private ulong _RoleId = (ulong)0;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"RoleId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((ulong)0)]
    public ulong RoleId
    {
      get { return _RoleId; }
      set { _RoleId = value; }
    }
    private int _CgId = (int)-1;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"CgId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int CgId
    {
      get { return _CgId; }
      set { _CgId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CGAnimationRpcCgOverNotifyNotify")]
  public partial class CGAnimationRpcCgOverNotifyNotify : global::ProtoBuf.IExtensible
  {
    public CGAnimationRpcCgOverNotifyNotify() {}
    
    private ulong _RoleId = (ulong)0;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"RoleId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((ulong)0)]
    public ulong RoleId
    {
      get { return _RoleId; }
      set { _RoleId = value; }
    }
    private int _CgId = (int)-1;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"CgId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int CgId
    {
      get { return _CgId; }
      set { _CgId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CGAnimationRpcCgSkipAsk")]
  public partial class CGAnimationRpcCgSkipAsk : global::ProtoBuf.IExtensible
  {
    public CGAnimationRpcCgSkipAsk() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CGAnimationRpcCgSkipReply")]
  public partial class CGAnimationRpcCgSkipReply : global::ProtoBuf.IExtensible
  {
    public CGAnimationRpcCgSkipReply() {}
    
    private int _Result = (int)-1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int Result
    {
      get { return _Result; }
      set { _Result = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CGAnimationRpcScriptPlayNotify")]
  public partial class CGAnimationRpcScriptPlayNotify : global::ProtoBuf.IExtensible
  {
    public CGAnimationRpcScriptPlayNotify() {}
    
    private ulong _CasterGuid = (ulong)0;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"CasterGuid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((ulong)0)]
    public ulong CasterGuid
    {
      get { return _CasterGuid; }
      set { _CasterGuid = value; }
    }
    private string _AnimantionName = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"AnimantionName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string AnimantionName
    {
      get { return _AnimantionName; }
      set { _AnimantionName = value; }
    }
    private float _Time = (float)-1;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"Time", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue((float)-1)]
    public float Time
    {
      get { return _Time; }
      set { _Time = value; }
    }
    private int _IsLoop = (int)-1;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"IsLoop", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int IsLoop
    {
      get { return _IsLoop; }
      set { _IsLoop = value; }
    }
    private int _SingleTime = (int)-1;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"SingleTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int SingleTime
    {
      get { return _SingleTime; }
      set { _SingleTime = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}