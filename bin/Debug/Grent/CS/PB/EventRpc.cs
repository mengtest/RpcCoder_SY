//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: EventRpc.proto
// Note: requires additional types generated from: PublicStruct.proto
namespace GenPB
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"EventRpcMoveNotify")]
  public partial class EventRpcMoveNotify : global::ProtoBuf.IExtensible
  {
    public EventRpcMoveNotify() {}
    
    private ulong _ObjId = (ulong)0;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"ObjId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((ulong)0)]
    public ulong ObjId
    {
      get { return _ObjId; }
      set { _ObjId = value; }
    }
    private Vector3 _Pos = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Pos", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Vector3 Pos
    {
      get { return _Pos; }
      set { _Pos = value; }
    }
    private float _Dir = (float)-1;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Dir", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue((float)-1)]
    public float Dir
    {
      get { return _Dir; }
      set { _Dir = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"EventRpcStopMoveNotify")]
  public partial class EventRpcStopMoveNotify : global::ProtoBuf.IExtensible
  {
    public EventRpcStopMoveNotify() {}
    
    private ulong _ObjId = (ulong)0;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"ObjId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((ulong)0)]
    public ulong ObjId
    {
      get { return _ObjId; }
      set { _ObjId = value; }
    }
    private Vector3Int _Pos = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Pos", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Vector3Int Pos
    {
      get { return _Pos; }
      set { _Pos = value; }
    }
    private float _Dir = (float)-1;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Dir", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue((float)-1)]
    public float Dir
    {
      get { return _Dir; }
      set { _Dir = value; }
    }
    private int _Type = (int)-1;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"Type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int Type
    {
      get { return _Type; }
      set { _Type = value; }
    }
    private bool _BrakeRush = (bool)false;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"BrakeRush", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue((bool)false)]
    public bool BrakeRush
    {
      get { return _BrakeRush; }
      set { _BrakeRush = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"EventRpcObjAttrChangeNotify")]
  public partial class EventRpcObjAttrChangeNotify : global::ProtoBuf.IExtensible
  {
    public EventRpcObjAttrChangeNotify() {}
    
    private float _Speed = (float)-1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Speed", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue((float)-1)]
    public float Speed
    {
      get { return _Speed; }
      set { _Speed = value; }
    }
    private long _Hp = (long)-1;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Hp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((long)-1)]
    public long Hp
    {
      get { return _Hp; }
      set { _Hp = value; }
    }
    private int _Status = (int)-1;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Status", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int Status
    {
      get { return _Status; }
      set { _Status = value; }
    }
    private int _ConfigId = (int)-1;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"ConfigId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int ConfigId
    {
      get { return _ConfigId; }
      set { _ConfigId = value; }
    }
    private ulong _ObjId = (ulong)0;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"ObjId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((ulong)0)]
    public ulong ObjId
    {
      get { return _ObjId; }
      set { _ObjId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"EventRpcCoinChangeNotify")]
  public partial class EventRpcCoinChangeNotify : global::ProtoBuf.IExtensible
  {
    public EventRpcCoinChangeNotify() {}
    
    private int _Type = (int)-1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int Type
    {
      get { return _Type; }
      set { _Type = value; }
    }
    private int _Value = (int)-1;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Value", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int Value
    {
      get { return _Value; }
      set { _Value = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"EventRpcMovePosNotify")]
  public partial class EventRpcMovePosNotify : global::ProtoBuf.IExtensible
  {
    public EventRpcMovePosNotify() {}
    
    private ulong _ObjId = (ulong)0;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"ObjId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((ulong)0)]
    public ulong ObjId
    {
      get { return _ObjId; }
      set { _ObjId = value; }
    }
    private readonly global::System.Collections.Generic.List<Vector3Int> _PosList = new global::System.Collections.Generic.List<Vector3Int>();
    [global::ProtoBuf.ProtoMember(3, Name=@"PosList", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Vector3Int> PosList
    {
      get { return _PosList; }
    }
  
    private float _Dir = (float)-1;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"Dir", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue((float)-1)]
    public float Dir
    {
      get { return _Dir; }
      set { _Dir = value; }
    }
    private bool _IsAllowChangeRunAnimation = (bool)true;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"IsAllowChangeRunAnimation", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue((bool)true)]
    public bool IsAllowChangeRunAnimation
    {
      get { return _IsAllowChangeRunAnimation; }
      set { _IsAllowChangeRunAnimation = value; }
    }
    private int _Follow = (int)-1;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"Follow", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int Follow
    {
      get { return _Follow; }
      set { _Follow = value; }
    }
    private bool _IsLookAtMoving = (bool)true;
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"IsLookAtMoving", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue((bool)true)]
    public bool IsLookAtMoving
    {
      get { return _IsLookAtMoving; }
      set { _IsLookAtMoving = value; }
    }
    private int _FromX = (int)-1;
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"FromX", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int FromX
    {
      get { return _FromX; }
      set { _FromX = value; }
    }
    private int _FromZ = (int)-1;
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"FromZ", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int FromZ
    {
      get { return _FromZ; }
      set { _FromZ = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"EventRpcDirNotify")]
  public partial class EventRpcDirNotify : global::ProtoBuf.IExtensible
  {
    public EventRpcDirNotify() {}
    
    private ulong _ObjId = (ulong)0;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"ObjId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((ulong)0)]
    public ulong ObjId
    {
      get { return _ObjId; }
      set { _ObjId = value; }
    }
    private float _Dir = (float)-1;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"Dir", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    [global::System.ComponentModel.DefaultValue((float)-1)]
    public float Dir
    {
      get { return _Dir; }
      set { _Dir = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"EventRpcStartFadeoutNotify")]
  public partial class EventRpcStartFadeoutNotify : global::ProtoBuf.IExtensible
  {
    public EventRpcStartFadeoutNotify() {}
    
    private ulong _ObjId = (ulong)0;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"ObjId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((ulong)0)]
    public ulong ObjId
    {
      get { return _ObjId; }
      set { _ObjId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"EventRpcCinematicStartNotify")]
  public partial class EventRpcCinematicStartNotify : global::ProtoBuf.IExtensible
  {
    public EventRpcCinematicStartNotify() {}
    
    private int _Text = (int)-1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Text", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int Text
    {
      get { return _Text; }
      set { _Text = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"EventRpcCinematicEndNotify")]
  public partial class EventRpcCinematicEndNotify : global::ProtoBuf.IExtensible
  {
    public EventRpcCinematicEndNotify() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}