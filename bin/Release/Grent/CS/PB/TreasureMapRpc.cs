//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: TreasureMapRpc.proto
// Note: requires additional types generated from: PublicStruct.proto
namespace GenPB
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TreasureMapRpcTreasureMapSyncAsk")]
  public partial class TreasureMapRpcTreasureMapSyncAsk : global::ProtoBuf.IExtensible
  {
    public TreasureMapRpcTreasureMapSyncAsk() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TreasureMapRpcTreasureMapSyncReply")]
  public partial class TreasureMapRpcTreasureMapSyncReply : global::ProtoBuf.IExtensible
  {
    public TreasureMapRpcTreasureMapSyncReply() {}
    
    private int _Result = (int)-1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int Result
    {
      get { return _Result; }
      set { _Result = value; }
    }
    private int _TreasureMapId = (int)-1;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"TreasureMapId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int TreasureMapId
    {
      get { return _TreasureMapId; }
      set { _TreasureMapId = value; }
    }
    private int _HighTreasureMapId = (int)-1;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"HighTreasureMapId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int HighTreasureMapId
    {
      get { return _HighTreasureMapId; }
      set { _HighTreasureMapId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TreasureMapRpcTreasureMapChangeNotify")]
  public partial class TreasureMapRpcTreasureMapChangeNotify : global::ProtoBuf.IExtensible
  {
    public TreasureMapRpcTreasureMapChangeNotify() {}
    
    private int _TreasureMapId = (int)-1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"TreasureMapId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int TreasureMapId
    {
      get { return _TreasureMapId; }
      set { _TreasureMapId = value; }
    }
    private int _HighTreasureMapId = (int)-1;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"HighTreasureMapId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int HighTreasureMapId
    {
      get { return _HighTreasureMapId; }
      set { _HighTreasureMapId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}