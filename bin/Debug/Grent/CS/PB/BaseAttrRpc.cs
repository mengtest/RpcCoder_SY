//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: BaseAttrRpc.proto
// Note: requires additional types generated from: PublicStruct.proto
namespace GenPB
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BaseAttrRpcSyncDataAsk")]
  public partial class BaseAttrRpcSyncDataAsk : global::ProtoBuf.IExtensible
  {
    public BaseAttrRpcSyncDataAsk() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BaseAttrRpcSyncDataReply")]
  public partial class BaseAttrRpcSyncDataReply : global::ProtoBuf.IExtensible
  {
    public BaseAttrRpcSyncDataReply() {}
    
    private int _Result = (int)-9999;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-9999)]
    public int Result
    {
      get { return _Result; }
      set { _Result = value; }
    }
    private byte[] _UpdateData = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"UpdateData", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] UpdateData
    {
      get { return _UpdateData; }
      set { _UpdateData = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BaseAttrRpcSyncNotify")]
  public partial class BaseAttrRpcSyncNotify : global::ProtoBuf.IExtensible
  {
    public BaseAttrRpcSyncNotify() {}
    
    private ulong _ObjId = (ulong)0;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"ObjId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((ulong)0)]
    public ulong ObjId
    {
      get { return _ObjId; }
      set { _ObjId = value; }
    }
    private byte[] _UpdateData = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"UpdateData", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] UpdateData
    {
      get { return _UpdateData; }
      set { _UpdateData = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}