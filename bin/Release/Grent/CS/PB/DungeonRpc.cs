//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: DungeonRpc.proto
// Note: requires additional types generated from: PublicStruct.proto
namespace GenPB
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DungeonRpcCreateDungeonAsk")]
  public partial class DungeonRpcCreateDungeonAsk : global::ProtoBuf.IExtensible
  {
    public DungeonRpcCreateDungeonAsk() {}
    
    private ulong _RoleId = (ulong)0;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"RoleId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((ulong)0)]
    public ulong RoleId
    {
      get { return _RoleId; }
      set { _RoleId = value; }
    }
    private int _DungeonConfigId = (int)-1;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"DungeonConfigId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int DungeonConfigId
    {
      get { return _DungeonConfigId; }
      set { _DungeonConfigId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DungeonRpcCreateDungeonReply")]
  public partial class DungeonRpcCreateDungeonReply : global::ProtoBuf.IExtensible
  {
    public DungeonRpcCreateDungeonReply() {}
    
    private int _Result = (int)-9999;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-9999)]
    public int Result
    {
      get { return _Result; }
      set { _Result = value; }
    }
    private int _DungeonConfigId = (int)-1;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"DungeonConfigId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int DungeonConfigId
    {
      get { return _DungeonConfigId; }
      set { _DungeonConfigId = value; }
    }
    private int _SceneConfigId = (int)-1;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"SceneConfigId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int SceneConfigId
    {
      get { return _SceneConfigId; }
      set { _SceneConfigId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DungeonRpcExitDungeonAsk")]
  public partial class DungeonRpcExitDungeonAsk : global::ProtoBuf.IExtensible
  {
    public DungeonRpcExitDungeonAsk() {}
    
    private ulong _RoleId = (ulong)0;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"RoleId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((ulong)0)]
    public ulong RoleId
    {
      get { return _RoleId; }
      set { _RoleId = value; }
    }
    private int _SceneId = (int)-1;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"SceneId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int SceneId
    {
      get { return _SceneId; }
      set { _SceneId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DungeonRpcExitDungeonReply")]
  public partial class DungeonRpcExitDungeonReply : global::ProtoBuf.IExtensible
  {
    public DungeonRpcExitDungeonReply() {}
    
    private int _Result = (int)-9999;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-9999)]
    public int Result
    {
      get { return _Result; }
      set { _Result = value; }
    }
    private int _SceneConfigId = (int)-1;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"SceneConfigId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int SceneConfigId
    {
      get { return _SceneConfigId; }
      set { _SceneConfigId = value; }
    }
    private int _SceneId = (int)-1;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"SceneId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int SceneId
    {
      get { return _SceneId; }
      set { _SceneId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DungeonRpcInformCreateDungeonAsk")]
  public partial class DungeonRpcInformCreateDungeonAsk : global::ProtoBuf.IExtensible
  {
    public DungeonRpcInformCreateDungeonAsk() {}
    
    private ulong _RoleId = (ulong)0;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"RoleId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((ulong)0)]
    public ulong RoleId
    {
      get { return _RoleId; }
      set { _RoleId = value; }
    }
    private int _TargetSceneId = (int)-1;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"TargetSceneId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int TargetSceneId
    {
      get { return _TargetSceneId; }
      set { _TargetSceneId = value; }
    }
    private int _DungeonConfigId = (int)-1;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"DungeonConfigId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int DungeonConfigId
    {
      get { return _DungeonConfigId; }
      set { _DungeonConfigId = value; }
    }
    private int _CurSceneId = (int)-1;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"CurSceneId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int CurSceneId
    {
      get { return _CurSceneId; }
      set { _CurSceneId = value; }
    }
    private int _Result = (int)-9999;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"Result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-9999)]
    public int Result
    {
      get { return _Result; }
      set { _Result = value; }
    }
    private readonly global::System.Collections.Generic.List<ulong> _RoleIds = new global::System.Collections.Generic.List<ulong>();
    [global::ProtoBuf.ProtoMember(6, Name=@"RoleIds", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<ulong> RoleIds
    {
      get { return _RoleIds; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DungeonRpcInformCreateDungeonReply")]
  public partial class DungeonRpcInformCreateDungeonReply : global::ProtoBuf.IExtensible
  {
    public DungeonRpcInformCreateDungeonReply() {}
    
    private int _Result = (int)-9999;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-9999)]
    public int Result
    {
      get { return _Result; }
      set { _Result = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DungeonRpcSettlementNotify")]
  public partial class DungeonRpcSettlementNotify : global::ProtoBuf.IExtensible
  {
    public DungeonRpcSettlementNotify() {}
    
    private int _SettlementResult = (int)-1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"SettlementResult", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int SettlementResult
    {
      get { return _SettlementResult; }
      set { _SettlementResult = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DungeonRpcEnterDungeonAsk")]
  public partial class DungeonRpcEnterDungeonAsk : global::ProtoBuf.IExtensible
  {
    public DungeonRpcEnterDungeonAsk() {}
    
    private int _SceneId = (int)-1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"SceneId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int SceneId
    {
      get { return _SceneId; }
      set { _SceneId = value; }
    }
    private int _DungeonConfigId = (int)-1;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"DungeonConfigId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int DungeonConfigId
    {
      get { return _DungeonConfigId; }
      set { _DungeonConfigId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DungeonRpcEnterDungeonReply")]
  public partial class DungeonRpcEnterDungeonReply : global::ProtoBuf.IExtensible
  {
    public DungeonRpcEnterDungeonReply() {}
    
    private int _Result = (int)-9999;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-9999)]
    public int Result
    {
      get { return _Result; }
      set { _Result = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DungeonRpcDungeonDataNotify")]
  public partial class DungeonRpcDungeonDataNotify : global::ProtoBuf.IExtensible
  {
    public DungeonRpcDungeonDataNotify() {}
    
    private int _BeginTime = (int)-1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"BeginTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int BeginTime
    {
      get { return _BeginTime; }
      set { _BeginTime = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DungeonRpcDungeonSyncAsk")]
  public partial class DungeonRpcDungeonSyncAsk : global::ProtoBuf.IExtensible
  {
    public DungeonRpcDungeonSyncAsk() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DungeonRpcDungeonSyncReply")]
  public partial class DungeonRpcDungeonSyncReply : global::ProtoBuf.IExtensible
  {
    public DungeonRpcDungeonSyncReply() {}
    
    private int _Result = (int)-1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int Result
    {
      get { return _Result; }
      set { _Result = value; }
    }
    private DungeonData _Data = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public DungeonData Data
    {
      get { return _Data; }
      set { _Data = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DungeonRpcDungeonListInfoAsk")]
  public partial class DungeonRpcDungeonListInfoAsk : global::ProtoBuf.IExtensible
  {
    public DungeonRpcDungeonListInfoAsk() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DungeonRpcDungeonListInfoReply")]
  public partial class DungeonRpcDungeonListInfoReply : global::ProtoBuf.IExtensible
  {
    public DungeonRpcDungeonListInfoReply() {}
    
    private int _Result = (int)-1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int Result
    {
      get { return _Result; }
      set { _Result = value; }
    }
    private readonly global::System.Collections.Generic.List<DungeonBossInfo> _DungeonBossData = new global::System.Collections.Generic.List<DungeonBossInfo>();
    [global::ProtoBuf.ProtoMember(3, Name=@"DungeonBossData", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<DungeonBossInfo> DungeonBossData
    {
      get { return _DungeonBossData; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DungeonRpcCreateTutorialAsk")]
  public partial class DungeonRpcCreateTutorialAsk : global::ProtoBuf.IExtensible
  {
    public DungeonRpcCreateTutorialAsk() {}
    
    private ulong _RoleId = (ulong)0;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"RoleId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((ulong)0)]
    public ulong RoleId
    {
      get { return _RoleId; }
      set { _RoleId = value; }
    }
    private int _DungeonConfigId = (int)-1;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"DungeonConfigId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int DungeonConfigId
    {
      get { return _DungeonConfigId; }
      set { _DungeonConfigId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DungeonRpcCreateTutorialReply")]
  public partial class DungeonRpcCreateTutorialReply : global::ProtoBuf.IExtensible
  {
    public DungeonRpcCreateTutorialReply() {}
    
    private int _Result = (int)-1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int Result
    {
      get { return _Result; }
      set { _Result = value; }
    }
    private int _DungeonConfigId = (int)-1;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"DungeonConfigId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int DungeonConfigId
    {
      get { return _DungeonConfigId; }
      set { _DungeonConfigId = value; }
    }
    private int _SceneConfigId = (int)-1;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"SceneConfigId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int SceneConfigId
    {
      get { return _SceneConfigId; }
      set { _SceneConfigId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DungeonRpcQuitTutorialAsk")]
  public partial class DungeonRpcQuitTutorialAsk : global::ProtoBuf.IExtensible
  {
    public DungeonRpcQuitTutorialAsk() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DungeonRpcQuitTutorialReply")]
  public partial class DungeonRpcQuitTutorialReply : global::ProtoBuf.IExtensible
  {
    public DungeonRpcQuitTutorialReply() {}
    
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
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DungeonRpcDungeonTargetNotify")]
  public partial class DungeonRpcDungeonTargetNotify : global::ProtoBuf.IExtensible
  {
    public DungeonRpcDungeonTargetNotify() {}
    
    private readonly global::System.Collections.Generic.List<DungeonTarget> _DungeonTarget = new global::System.Collections.Generic.List<DungeonTarget>();
    [global::ProtoBuf.ProtoMember(1, Name=@"DungeonTarget", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<DungeonTarget> DungeonTarget
    {
      get { return _DungeonTarget; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DungeonRpcTargetContentChangeNotify")]
  public partial class DungeonRpcTargetContentChangeNotify : global::ProtoBuf.IExtensible
  {
    public DungeonRpcTargetContentChangeNotify() {}
    
    private int _Index = (int)-1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Index", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int Index
    {
      get { return _Index; }
      set { _Index = value; }
    }
    private int _SubIndex = (int)-1;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"SubIndex", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int SubIndex
    {
      get { return _SubIndex; }
      set { _SubIndex = value; }
    }
    private int _CurCount = (int)-1;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"CurCount", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int CurCount
    {
      get { return _CurCount; }
      set { _CurCount = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DungeonRpcDungeon_NotifyNotify")]
  public partial class DungeonRpcDungeon_NotifyNotify : global::ProtoBuf.IExtensible
  {
    public DungeonRpcDungeon_NotifyNotify() {}
    
    private int _TextId = (int)-1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"TextId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int TextId
    {
      get { return _TextId; }
      set { _TextId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}