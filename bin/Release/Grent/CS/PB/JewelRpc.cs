//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: JewelRpc.proto
// Note: requires additional types generated from: PublicStruct.proto
namespace GenPB
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"JewelRpcJewelSyncAsk")]
  public partial class JewelRpcJewelSyncAsk : global::ProtoBuf.IExtensible
  {
    public JewelRpcJewelSyncAsk() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"JewelRpcJewelSyncReply")]
  public partial class JewelRpcJewelSyncReply : global::ProtoBuf.IExtensible
  {
    public JewelRpcJewelSyncReply() {}
    
    private int _Result = (int)-1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int Result
    {
      get { return _Result; }
      set { _Result = value; }
    }
    private readonly global::System.Collections.Generic.List<JewelInfo> _JewelInfos = new global::System.Collections.Generic.List<JewelInfo>();
    [global::ProtoBuf.ProtoMember(2, Name=@"JewelInfos", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<JewelInfo> JewelInfos
    {
      get { return _JewelInfos; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"JewelRpcInsetJewelAsk")]
  public partial class JewelRpcInsetJewelAsk : global::ProtoBuf.IExtensible
  {
    public JewelRpcInsetJewelAsk() {}
    
    private int _EquipSlot = (int)-1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"EquipSlot", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int EquipSlot
    {
      get { return _EquipSlot; }
      set { _EquipSlot = value; }
    }
    private int _JewelId = (int)-1;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"JewelId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int JewelId
    {
      get { return _JewelId; }
      set { _JewelId = value; }
    }
    private int _JewelSlot = (int)-1;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"JewelSlot", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int JewelSlot
    {
      get { return _JewelSlot; }
      set { _JewelSlot = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"JewelRpcInsetJewelReply")]
  public partial class JewelRpcInsetJewelReply : global::ProtoBuf.IExtensible
  {
    public JewelRpcInsetJewelReply() {}
    
    private int _Result = (int)-1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int Result
    {
      get { return _Result; }
      set { _Result = value; }
    }
    private JewelInfo _JewelInfo = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"JewelInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public JewelInfo JewelInfo
    {
      get { return _JewelInfo; }
      set { _JewelInfo = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"JewelRpcRemoveJewelAsk")]
  public partial class JewelRpcRemoveJewelAsk : global::ProtoBuf.IExtensible
  {
    public JewelRpcRemoveJewelAsk() {}
    
    private int _EquipSlot = (int)-1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"EquipSlot", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int EquipSlot
    {
      get { return _EquipSlot; }
      set { _EquipSlot = value; }
    }
    private int _JewelSlot = (int)-1;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"JewelSlot", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int JewelSlot
    {
      get { return _JewelSlot; }
      set { _JewelSlot = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"JewelRpcRemoveJewelReply")]
  public partial class JewelRpcRemoveJewelReply : global::ProtoBuf.IExtensible
  {
    public JewelRpcRemoveJewelReply() {}
    
    private int _Result = (int)-1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int Result
    {
      get { return _Result; }
      set { _Result = value; }
    }
    private JewelInfo _JewelInfo = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"JewelInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public JewelInfo JewelInfo
    {
      get { return _JewelInfo; }
      set { _JewelInfo = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"JewelRpcCompoundJewelAsk")]
  public partial class JewelRpcCompoundJewelAsk : global::ProtoBuf.IExtensible
  {
    public JewelRpcCompoundJewelAsk() {}
    
    private int _JewelId = (int)-1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"JewelId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int JewelId
    {
      get { return _JewelId; }
      set { _JewelId = value; }
    }
    private bool _UseSafeItem = (bool)false;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"UseSafeItem", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue((bool)false)]
    public bool UseSafeItem
    {
      get { return _UseSafeItem; }
      set { _UseSafeItem = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"JewelRpcCompoundJewelReply")]
  public partial class JewelRpcCompoundJewelReply : global::ProtoBuf.IExtensible
  {
    public JewelRpcCompoundJewelReply() {}
    
    private int _Result = (int)-1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int Result
    {
      get { return _Result; }
      set { _Result = value; }
    }
    private int _JewelId = (int)-1;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"JewelId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int JewelId
    {
      get { return _JewelId; }
      set { _JewelId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"JewelRpcCompoundSetJewelAsk")]
  public partial class JewelRpcCompoundSetJewelAsk : global::ProtoBuf.IExtensible
  {
    public JewelRpcCompoundSetJewelAsk() {}
    
    private int _EquipType = (int)-1;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"EquipType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int EquipType
    {
      get { return _EquipType; }
      set { _EquipType = value; }
    }
    private int _JewelSlot = (int)-1;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"JewelSlot", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int JewelSlot
    {
      get { return _JewelSlot; }
      set { _JewelSlot = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"JewelRpcCompoundSetJewelReply")]
  public partial class JewelRpcCompoundSetJewelReply : global::ProtoBuf.IExtensible
  {
    public JewelRpcCompoundSetJewelReply() {}
    
    private int _Result = (int)-1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int Result
    {
      get { return _Result; }
      set { _Result = value; }
    }
    private JewelInfo _JewelInfo = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"JewelInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public JewelInfo JewelInfo
    {
      get { return _JewelInfo; }
      set { _JewelInfo = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"JewelRpcUnlockJewelSlotAsk")]
  public partial class JewelRpcUnlockJewelSlotAsk : global::ProtoBuf.IExtensible
  {
    public JewelRpcUnlockJewelSlotAsk() {}
    
    private int _EquipSlot = (int)-1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"EquipSlot", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int EquipSlot
    {
      get { return _EquipSlot; }
      set { _EquipSlot = value; }
    }
    private int _JewelSlot = (int)-1;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"JewelSlot", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int JewelSlot
    {
      get { return _JewelSlot; }
      set { _JewelSlot = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"JewelRpcUnlockJewelSlotReply")]
  public partial class JewelRpcUnlockJewelSlotReply : global::ProtoBuf.IExtensible
  {
    public JewelRpcUnlockJewelSlotReply() {}
    
    private int _Result = (int)-1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int Result
    {
      get { return _Result; }
      set { _Result = value; }
    }
    private JewelInfo _JewelInfo = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"JewelInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public JewelInfo JewelInfo
    {
      get { return _JewelInfo; }
      set { _JewelInfo = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"JewelRpcQuickCompoundAsk")]
  public partial class JewelRpcQuickCompoundAsk : global::ProtoBuf.IExtensible
  {
    public JewelRpcQuickCompoundAsk() {}
    
    private int _JewelId = (int)-1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"JewelId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int JewelId
    {
      get { return _JewelId; }
      set { _JewelId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"JewelRpcQuickCompoundReply")]
  public partial class JewelRpcQuickCompoundReply : global::ProtoBuf.IExtensible
  {
    public JewelRpcQuickCompoundReply() {}
    
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
  
}