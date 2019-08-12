//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: WorldServerRpc.proto
// Note: requires additional types generated from: PublicStruct.proto
namespace GenPB
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"WorldServerRpcEnterSceneAsk")]
  public partial class WorldServerRpcEnterSceneAsk : global::ProtoBuf.IExtensible
  {
    public WorldServerRpcEnterSceneAsk() {}
    
    private ulong _RoleId = (ulong)0;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"RoleId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((ulong)0)]
    public ulong RoleId
    {
      get { return _RoleId; }
      set { _RoleId = value; }
    }
    private CharacterLocation _Location = null;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"Location", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CharacterLocation Location
    {
      get { return _Location; }
      set { _Location = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"WorldServerRpcEnterSceneReply")]
  public partial class WorldServerRpcEnterSceneReply : global::ProtoBuf.IExtensible
  {
    public WorldServerRpcEnterSceneReply() {}
    
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
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"WorldServerRpcLoginGameServerAsk")]
  public partial class WorldServerRpcLoginGameServerAsk : global::ProtoBuf.IExtensible
  {
    public WorldServerRpcLoginGameServerAsk() {}
    
    private TeamInfo _Team = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Team", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public TeamInfo Team
    {
      get { return _Team; }
      set { _Team = value; }
    }
    private OnlineUserInfo _RoleInfo = null;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"RoleInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public OnlineUserInfo RoleInfo
    {
      get { return _RoleInfo; }
      set { _RoleInfo = value; }
    }
    private CharacterLocation _Location = null;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"Location", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CharacterLocation Location
    {
      get { return _Location; }
      set { _Location = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"WorldServerRpcLogoutGameServerAsk")]
  public partial class WorldServerRpcLogoutGameServerAsk : global::ProtoBuf.IExtensible
  {
    public WorldServerRpcLogoutGameServerAsk() {}
    
    private int _Result = (int)-9999;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-9999)]
    public int Result
    {
      get { return _Result; }
      set { _Result = value; }
    }
    private OnlineUserInfo _RoleInfo = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"RoleInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public OnlineUserInfo RoleInfo
    {
      get { return _RoleInfo; }
      set { _RoleInfo = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"WorldServerRpcUpdateRoleInfoAsk")]
  public partial class WorldServerRpcUpdateRoleInfoAsk : global::ProtoBuf.IExtensible
  {
    public WorldServerRpcUpdateRoleInfoAsk() {}
    
    private OnlineUserInfo _RoleInfo = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"RoleInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public OnlineUserInfo RoleInfo
    {
      get { return _RoleInfo; }
      set { _RoleInfo = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"WorldServerRpcUpdateRoleInfoReply")]
  public partial class WorldServerRpcUpdateRoleInfoReply : global::ProtoBuf.IExtensible
  {
    public WorldServerRpcUpdateRoleInfoReply() {}
    
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
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"WorldServerRpcCreateDungeonNotifyAsk")]
  public partial class WorldServerRpcCreateDungeonNotifyAsk : global::ProtoBuf.IExtensible
  {
    public WorldServerRpcCreateDungeonNotifyAsk() {}
    
    private int _CurSceneId = (int)-1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"CurSceneId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int CurSceneId
    {
      get { return _CurSceneId; }
      set { _CurSceneId = value; }
    }
    private ulong _RoleId = (ulong)0;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"RoleId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((ulong)0)]
    public ulong RoleId
    {
      get { return _RoleId; }
      set { _RoleId = value; }
    }
    private int _TargetSceneId = (int)-1;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"TargetSceneId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int TargetSceneId
    {
      get { return _TargetSceneId; }
      set { _TargetSceneId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"WorldServerRpcCreateDungeonNotifyReply")]
  public partial class WorldServerRpcCreateDungeonNotifyReply : global::ProtoBuf.IExtensible
  {
    public WorldServerRpcCreateDungeonNotifyReply() {}
    
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
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"WorldServerRpcExitDungeonAsk")]
  public partial class WorldServerRpcExitDungeonAsk : global::ProtoBuf.IExtensible
  {
    public WorldServerRpcExitDungeonAsk() {}
    
    private ulong _RoleId = (ulong)0;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"RoleId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((ulong)0)]
    public ulong RoleId
    {
      get { return _RoleId; }
      set { _RoleId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"WorldServerRpcExitDungeonReply")]
  public partial class WorldServerRpcExitDungeonReply : global::ProtoBuf.IExtensible
  {
    public WorldServerRpcExitDungeonReply() {}
    
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
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"WorldServerRpcUpdateTeamInfoAsk")]
  public partial class WorldServerRpcUpdateTeamInfoAsk : global::ProtoBuf.IExtensible
  {
    public WorldServerRpcUpdateTeamInfoAsk() {}
    
    private TeamMemberInfo _TeamMember = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"TeamMember", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public TeamMemberInfo TeamMember
    {
      get { return _TeamMember; }
      set { _TeamMember = value; }
    }
    private ulong _RoleId = (ulong)0;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"RoleId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((ulong)0)]
    public ulong RoleId
    {
      get { return _RoleId; }
      set { _RoleId = value; }
    }
    private TeamInfo _Team = null;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"Team", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public TeamInfo Team
    {
      get { return _Team; }
      set { _Team = value; }
    }
    private int _TeamType = (int)-1;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"TeamType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int TeamType
    {
      get { return _TeamType; }
      set { _TeamType = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"WorldServerRpcUpdateTeamInfoReply")]
  public partial class WorldServerRpcUpdateTeamInfoReply : global::ProtoBuf.IExtensible
  {
    public WorldServerRpcUpdateTeamInfoReply() {}
    
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
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"WorldServerRpcPlayCgTeamAsk")]
  public partial class WorldServerRpcPlayCgTeamAsk : global::ProtoBuf.IExtensible
  {
    public WorldServerRpcPlayCgTeamAsk() {}
    
    private ulong _PlayRoleId = (ulong)0;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"PlayRoleId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((ulong)0)]
    public ulong PlayRoleId
    {
      get { return _PlayRoleId; }
      set { _PlayRoleId = value; }
    }
    private int _CgId = (int)-1;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"CgId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int CgId
    {
      get { return _CgId; }
      set { _CgId = value; }
    }
    private int _State = (int)-1;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"State", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int State
    {
      get { return _State; }
      set { _State = value; }
    }
    private ulong _RoleId = (ulong)0;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"RoleId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((ulong)0)]
    public ulong RoleId
    {
      get { return _RoleId; }
      set { _RoleId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"WorldServerRpcPlayCgTeamReply")]
  public partial class WorldServerRpcPlayCgTeamReply : global::ProtoBuf.IExtensible
  {
    public WorldServerRpcPlayCgTeamReply() {}
    
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
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"WorldServerRpcSendMailAsk")]
  public partial class WorldServerRpcSendMailAsk : global::ProtoBuf.IExtensible
  {
    public WorldServerRpcSendMailAsk() {}
    
    private MailInfo _Mail = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Mail", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public MailInfo Mail
    {
      get { return _Mail; }
      set { _Mail = value; }
    }
    private ulong _GlobalMailID = (ulong)0;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"GlobalMailID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((ulong)0)]
    public ulong GlobalMailID
    {
      get { return _GlobalMailID; }
      set { _GlobalMailID = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"WorldServerRpcSendMailReply")]
  public partial class WorldServerRpcSendMailReply : global::ProtoBuf.IExtensible
  {
    public WorldServerRpcSendMailReply() {}
    
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
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"WorldServerRpcChangeTeamTypeAsk")]
  public partial class WorldServerRpcChangeTeamTypeAsk : global::ProtoBuf.IExtensible
  {
    public WorldServerRpcChangeTeamTypeAsk() {}
    
    private ulong _TeamId = (ulong)0;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"TeamId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((ulong)0)]
    public ulong TeamId
    {
      get { return _TeamId; }
      set { _TeamId = value; }
    }
    private ulong _RoleId = (ulong)0;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"RoleId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((ulong)0)]
    public ulong RoleId
    {
      get { return _RoleId; }
      set { _RoleId = value; }
    }
    private int _Result = (int)-1;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int Result
    {
      get { return _Result; }
      set { _Result = value; }
    }
    private int _TeamType = (int)-1;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"TeamType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int TeamType
    {
      get { return _TeamType; }
      set { _TeamType = value; }
    }
    private TeamTarget _Target = null;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"Target", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public TeamTarget Target
    {
      get { return _Target; }
      set { _Target = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"WorldServerRpcChangeTeamTypeReply")]
  public partial class WorldServerRpcChangeTeamTypeReply : global::ProtoBuf.IExtensible
  {
    public WorldServerRpcChangeTeamTypeReply() {}
    
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
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"WorldServerRpcAutoMatchAsk")]
  public partial class WorldServerRpcAutoMatchAsk : global::ProtoBuf.IExtensible
  {
    public WorldServerRpcAutoMatchAsk() {}
    
    private TeamMemberInfo _MemberInfo = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"MemberInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public TeamMemberInfo MemberInfo
    {
      get { return _MemberInfo; }
      set { _MemberInfo = value; }
    }
    private PlayerMatchData _MatchInfo = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"MatchInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public PlayerMatchData MatchInfo
    {
      get { return _MatchInfo; }
      set { _MatchInfo = value; }
    }
    private int _Result = (int)-1;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"Result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"WorldServerRpcAutoMatchReply")]
  public partial class WorldServerRpcAutoMatchReply : global::ProtoBuf.IExtensible
  {
    public WorldServerRpcAutoMatchReply() {}
    
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
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"WorldServerRpcCancelMatchAsk")]
  public partial class WorldServerRpcCancelMatchAsk : global::ProtoBuf.IExtensible
  {
    public WorldServerRpcCancelMatchAsk() {}
    
    private ulong _RoleId = (ulong)0;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"RoleId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((ulong)0)]
    public ulong RoleId
    {
      get { return _RoleId; }
      set { _RoleId = value; }
    }
    private int _Result = (int)-1;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int Result
    {
      get { return _Result; }
      set { _Result = value; }
    }
    private int _IsNotify = (int)0;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"IsNotify", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int IsNotify
    {
      get { return _IsNotify; }
      set { _IsNotify = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"WorldServerRpcCancelMatchReply")]
  public partial class WorldServerRpcCancelMatchReply : global::ProtoBuf.IExtensible
  {
    public WorldServerRpcCancelMatchReply() {}
    
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
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"WorldServerRpcLoginGameServerReply")]
  public partial class WorldServerRpcLoginGameServerReply : global::ProtoBuf.IExtensible
  {
    public WorldServerRpcLoginGameServerReply() {}
    
    private int _Result = (int)-1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int Result
    {
      get { return _Result; }
      set { _Result = value; }
    }
    private TeamInfo _Team = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Team", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public TeamInfo Team
    {
      get { return _Team; }
      set { _Team = value; }
    }
    private OnlineUserInfo _RoleInfo = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"RoleInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public OnlineUserInfo RoleInfo
    {
      get { return _RoleInfo; }
      set { _RoleInfo = value; }
    }
    private CharacterLocation _Location = null;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"Location", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public CharacterLocation Location
    {
      get { return _Location; }
      set { _Location = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"WorldServerRpcLogoutGameServerReply")]
  public partial class WorldServerRpcLogoutGameServerReply : global::ProtoBuf.IExtensible
  {
    public WorldServerRpcLogoutGameServerReply() {}
    
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
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"WorldServerRpcGetPlayerInfoAsk")]
  public partial class WorldServerRpcGetPlayerInfoAsk : global::ProtoBuf.IExtensible
  {
    public WorldServerRpcGetPlayerInfoAsk() {}
    
    private ulong _Player_guid = (ulong)0;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Player_guid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((ulong)0)]
    public ulong Player_guid
    {
      get { return _Player_guid; }
      set { _Player_guid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"WorldServerRpcGetPlayerInfoReply")]
  public partial class WorldServerRpcGetPlayerInfoReply : global::ProtoBuf.IExtensible
  {
    public WorldServerRpcGetPlayerInfoReply() {}
    
    private int _Result = (int)-1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int Result
    {
      get { return _Result; }
      set { _Result = value; }
    }
    private string _Player_name = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Player_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Player_name
    {
      get { return _Player_name; }
      set { _Player_name = value; }
    }
    private ulong _Player_guid = (ulong)0;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Player_guid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((ulong)0)]
    public ulong Player_guid
    {
      get { return _Player_guid; }
      set { _Player_guid = value; }
    }
    private int _Avatar_id = (int)-1;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"Avatar_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int Avatar_id
    {
      get { return _Avatar_id; }
      set { _Avatar_id = value; }
    }
    private int _Player_level = (int)-1;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"Player_level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int Player_level
    {
      get { return _Player_level; }
      set { _Player_level = value; }
    }
    private int _Avatar_frame_id = (int)-1;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"Avatar_frame_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int Avatar_frame_id
    {
      get { return _Avatar_frame_id; }
      set { _Avatar_frame_id = value; }
    }
    private int _Config_id = (int)-1;
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"Config_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int Config_id
    {
      get { return _Config_id; }
      set { _Config_id = value; }
    }
    private ulong _Guild_id = (ulong)0;
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"Guild_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((ulong)0)]
    public ulong Guild_id
    {
      get { return _Guild_id; }
      set { _Guild_id = value; }
    }
    private string _Guild_name = "";
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"Guild_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Guild_name
    {
      get { return _Guild_name; }
      set { _Guild_name = value; }
    }
    private readonly global::System.Collections.Generic.List<ItemData> _Equip_data = new global::System.Collections.Generic.List<ItemData>();
    [global::ProtoBuf.ProtoMember(10, Name=@"Equip_data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<ItemData> Equip_data
    {
      get { return _Equip_data; }
    }
  
    private readonly global::System.Collections.Generic.List<SuitInfo> _Suit_infos = new global::System.Collections.Generic.List<SuitInfo>();
    [global::ProtoBuf.ProtoMember(11, Name=@"Suit_infos", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<SuitInfo> Suit_infos
    {
      get { return _Suit_infos; }
    }
  
    private readonly global::System.Collections.Generic.List<EquipSlotInfo> _EquipSlotData = new global::System.Collections.Generic.List<EquipSlotInfo>();
    [global::ProtoBuf.ProtoMember(12, Name=@"EquipSlotData", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<EquipSlotInfo> EquipSlotData
    {
      get { return _EquipSlotData; }
    }
  
    private readonly global::System.Collections.Generic.List<EquipSlotStarInfo> _EquipSlotStarList = new global::System.Collections.Generic.List<EquipSlotStarInfo>();
    [global::ProtoBuf.ProtoMember(13, Name=@"EquipSlotStarList", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<EquipSlotStarInfo> EquipSlotStarList
    {
      get { return _EquipSlotStarList; }
    }
  
    private readonly global::System.Collections.Generic.List<JewelInfo> _JewelInfos = new global::System.Collections.Generic.List<JewelInfo>();
    [global::ProtoBuf.ProtoMember(14, Name=@"JewelInfos", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<JewelInfo> JewelInfos
    {
      get { return _JewelInfos; }
    }
  
    private int _BattleScore = (int)-1;
    [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"BattleScore", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int BattleScore
    {
      get { return _BattleScore; }
      set { _BattleScore = value; }
    }
    private ItemData _Pet_item_data = null;
    [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"Pet_item_data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public ItemData Pet_item_data
    {
      get { return _Pet_item_data; }
      set { _Pet_item_data = value; }
    }
    private int _TreasureHair = (int)-1;
    [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"TreasureHair", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int TreasureHair
    {
      get { return _TreasureHair; }
      set { _TreasureHair = value; }
    }
    private int _TreasureHead = (int)-1;
    [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"TreasureHead", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int TreasureHead
    {
      get { return _TreasureHead; }
      set { _TreasureHead = value; }
    }
    private int _TreasureBody = (int)-1;
    [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"TreasureBody", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int TreasureBody
    {
      get { return _TreasureBody; }
      set { _TreasureBody = value; }
    }
    private int _TreasureWeapon = (int)-1;
    [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"TreasureWeapon", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int TreasureWeapon
    {
      get { return _TreasureWeapon; }
      set { _TreasureWeapon = value; }
    }
    private int _TreasureWing = (int)-1;
    [global::ProtoBuf.ProtoMember(23, IsRequired = false, Name=@"TreasureWing", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int TreasureWing
    {
      get { return _TreasureWing; }
      set { _TreasureWing = value; }
    }
    private ulong _TeamId = (ulong)0;
    [global::ProtoBuf.ProtoMember(24, IsRequired = false, Name=@"TeamId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((ulong)0)]
    public ulong TeamId
    {
      get { return _TeamId; }
      set { _TeamId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}