//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: EquipSlotRpc.proto
// Note: requires additional types generated from: PublicStruct.proto
namespace GenPB
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"EquipSlotRpcSyncEquipSlotAsk")]
  public partial class EquipSlotRpcSyncEquipSlotAsk : global::ProtoBuf.IExtensible
  {
    public EquipSlotRpcSyncEquipSlotAsk() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"EquipSlotRpcSyncEquipSlotReply")]
  public partial class EquipSlotRpcSyncEquipSlotReply : global::ProtoBuf.IExtensible
  {
    public EquipSlotRpcSyncEquipSlotReply() {}
    
    private int _Result = (int)-1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int Result
    {
      get { return _Result; }
      set { _Result = value; }
    }
    private readonly global::System.Collections.Generic.List<EquipSlotInfo> _EquipSlotData = new global::System.Collections.Generic.List<EquipSlotInfo>();
    [global::ProtoBuf.ProtoMember(2, Name=@"EquipSlotData", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<EquipSlotInfo> EquipSlotData
    {
      get { return _EquipSlotData; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"EquipSlotRpcEnhanceEquipSlotAsk")]
  public partial class EquipSlotRpcEnhanceEquipSlotAsk : global::ProtoBuf.IExtensible
  {
    public EquipSlotRpcEnhanceEquipSlotAsk() {}
    
    private int _Slot_Type = (int)-1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Slot_Type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int Slot_Type
    {
      get { return _Slot_Type; }
      set { _Slot_Type = value; }
    }
    private readonly global::System.Collections.Generic.List<ItemSimpleData> _CostItemList = new global::System.Collections.Generic.List<ItemSimpleData>();
    [global::ProtoBuf.ProtoMember(2, Name=@"CostItemList", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<ItemSimpleData> CostItemList
    {
      get { return _CostItemList; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"EquipSlotRpcEnhanceEquipSlotReply")]
  public partial class EquipSlotRpcEnhanceEquipSlotReply : global::ProtoBuf.IExtensible
  {
    public EquipSlotRpcEnhanceEquipSlotReply() {}
    
    private int _Result = (int)-1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int Result
    {
      get { return _Result; }
      set { _Result = value; }
    }
    private readonly global::System.Collections.Generic.List<EquipSlotInfo> _EquipSlotData = new global::System.Collections.Generic.List<EquipSlotInfo>();
    [global::ProtoBuf.ProtoMember(2, Name=@"EquipSlotData", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<EquipSlotInfo> EquipSlotData
    {
      get { return _EquipSlotData; }
    }
  
    private int _Slot_Type = (int)-1;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Slot_Type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int Slot_Type
    {
      get { return _Slot_Type; }
      set { _Slot_Type = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"EquipSlotRpcUpStarEquipSlotAsk")]
  public partial class EquipSlotRpcUpStarEquipSlotAsk : global::ProtoBuf.IExtensible
  {
    public EquipSlotRpcUpStarEquipSlotAsk() {}
    
    private int _Slot_Type = (int)-1;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Slot_Type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int Slot_Type
    {
      get { return _Slot_Type; }
      set { _Slot_Type = value; }
    }
    private bool _IsProtection = (bool)false;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"IsProtection", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue((bool)false)]
    public bool IsProtection
    {
      get { return _IsProtection; }
      set { _IsProtection = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"EquipSlotRpcUpStarEquipSlotReply")]
  public partial class EquipSlotRpcUpStarEquipSlotReply : global::ProtoBuf.IExtensible
  {
    public EquipSlotRpcUpStarEquipSlotReply() {}
    
    private int _Result = (int)-1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int Result
    {
      get { return _Result; }
      set { _Result = value; }
    }
    private readonly global::System.Collections.Generic.List<EquipSlotStarInfo> _EquipSlotStarList = new global::System.Collections.Generic.List<EquipSlotStarInfo>();
    [global::ProtoBuf.ProtoMember(2, Name=@"EquipSlotStarList", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<EquipSlotStarInfo> EquipSlotStarList
    {
      get { return _EquipSlotStarList; }
    }
  
    private int _Slot_Type = (int)-1;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Slot_Type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int Slot_Type
    {
      get { return _Slot_Type; }
      set { _Slot_Type = value; }
    }
    private int _UpStarResult = (int)-1;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"UpStarResult", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int UpStarResult
    {
      get { return _UpStarResult; }
      set { _UpStarResult = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"EquipSlotRpcSyncEquipSlotStarAsk")]
  public partial class EquipSlotRpcSyncEquipSlotStarAsk : global::ProtoBuf.IExtensible
  {
    public EquipSlotRpcSyncEquipSlotStarAsk() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"EquipSlotRpcSyncEquipSlotStarReply")]
  public partial class EquipSlotRpcSyncEquipSlotStarReply : global::ProtoBuf.IExtensible
  {
    public EquipSlotRpcSyncEquipSlotStarReply() {}
    
    private int _Result = (int)-1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int Result
    {
      get { return _Result; }
      set { _Result = value; }
    }
    private readonly global::System.Collections.Generic.List<EquipSlotStarInfo> _EquipSlotStarList = new global::System.Collections.Generic.List<EquipSlotStarInfo>();
    [global::ProtoBuf.ProtoMember(2, Name=@"EquipSlotStarList", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<EquipSlotStarInfo> EquipSlotStarList
    {
      get { return _EquipSlotStarList; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}