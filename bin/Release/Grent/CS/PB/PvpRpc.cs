//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: PvpRpc.proto
// Note: requires additional types generated from: PublicStruct.proto
namespace GenPB
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PvpRpcRankAsk")]
  public partial class PvpRpcRankAsk : global::ProtoBuf.IExtensible
  {
    public PvpRpcRankAsk() {}
    
    private int _PvpType = (int)-1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"PvpType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int PvpType
    {
      get { return _PvpType; }
      set { _PvpType = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PvpRpcRankReply")]
  public partial class PvpRpcRankReply : global::ProtoBuf.IExtensible
  {
    public PvpRpcRankReply() {}
    
    private int _Result = (int)-1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int Result
    {
      get { return _Result; }
      set { _Result = value; }
    }
    private readonly global::System.Collections.Generic.List<PvpPlayerInfo> _RankList = new global::System.Collections.Generic.List<PvpPlayerInfo>();
    [global::ProtoBuf.ProtoMember(2, Name=@"RankList", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<PvpPlayerInfo> RankList
    {
      get { return _RankList; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PvpRpcMatchAsk")]
  public partial class PvpRpcMatchAsk : global::ProtoBuf.IExtensible
  {
    public PvpRpcMatchAsk() {}
    
    private int _PvpType = (int)-1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"PvpType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int PvpType
    {
      get { return _PvpType; }
      set { _PvpType = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PvpRpcMatchReply")]
  public partial class PvpRpcMatchReply : global::ProtoBuf.IExtensible
  {
    public PvpRpcMatchReply() {}
    
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
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PvpRpcMatchNotifyNotify")]
  public partial class PvpRpcMatchNotifyNotify : global::ProtoBuf.IExtensible
  {
    public PvpRpcMatchNotifyNotify() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PvpRpcMatchCancleAsk")]
  public partial class PvpRpcMatchCancleAsk : global::ProtoBuf.IExtensible
  {
    public PvpRpcMatchCancleAsk() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PvpRpcMatchCancleReply")]
  public partial class PvpRpcMatchCancleReply : global::ProtoBuf.IExtensible
  {
    public PvpRpcMatchCancleReply() {}
    
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
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PvpRpcMatchCancleNotifyNotify")]
  public partial class PvpRpcMatchCancleNotifyNotify : global::ProtoBuf.IExtensible
  {
    public PvpRpcMatchCancleNotifyNotify() {}
    
    private ulong _RoleId = (ulong)0;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"RoleId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((ulong)0)]
    public ulong RoleId
    {
      get { return _RoleId; }
      set { _RoleId = value; }
    }
    private string _Name = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Name
    {
      get { return _Name; }
      set { _Name = value; }
    }
    private int _Reason = (int)-1;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Reason", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int Reason
    {
      get { return _Reason; }
      set { _Reason = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PvpRpcPlayerReadyAsk")]
  public partial class PvpRpcPlayerReadyAsk : global::ProtoBuf.IExtensible
  {
    public PvpRpcPlayerReadyAsk() {}
    
    private int _OpreationType = (int)-1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"OpreationType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int OpreationType
    {
      get { return _OpreationType; }
      set { _OpreationType = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PvpRpcPlayerReadyReply")]
  public partial class PvpRpcPlayerReadyReply : global::ProtoBuf.IExtensible
  {
    public PvpRpcPlayerReadyReply() {}
    
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
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PvpRpcPlayerReadyNotifyNotify")]
  public partial class PvpRpcPlayerReadyNotifyNotify : global::ProtoBuf.IExtensible
  {
    public PvpRpcPlayerReadyNotifyNotify() {}
    
    private ulong _RoleId = (ulong)0;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"RoleId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((ulong)0)]
    public ulong RoleId
    {
      get { return _RoleId; }
      set { _RoleId = value; }
    }
    private int _OpType = (int)-1;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"OpType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int OpType
    {
      get { return _OpType; }
      set { _OpType = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PvpRpcReadyFaildNotify")]
  public partial class PvpRpcReadyFaildNotify : global::ProtoBuf.IExtensible
  {
    public PvpRpcReadyFaildNotify() {}
    
    private int _Reason = (int)-1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Reason", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int Reason
    {
      get { return _Reason; }
      set { _Reason = value; }
    }
    private ulong _RoleId = (ulong)0;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"RoleId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PvpRpcPvpBattleStartNotify")]
  public partial class PvpRpcPvpBattleStartNotify : global::ProtoBuf.IExtensible
  {
    public PvpRpcPvpBattleStartNotify() {}
    
    private int _LeftKill = (int)-1;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"LeftKill", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int LeftKill
    {
      get { return _LeftKill; }
      set { _LeftKill = value; }
    }
    private int _RightKill = (int)-1;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"RightKill", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int RightKill
    {
      get { return _RightKill; }
      set { _RightKill = value; }
    }
    private int _NeedKill = (int)-1;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"NeedKill", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int NeedKill
    {
      get { return _NeedKill; }
      set { _NeedKill = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PvpRpcPvpBattleEndNotify")]
  public partial class PvpRpcPvpBattleEndNotify : global::ProtoBuf.IExtensible
  {
    public PvpRpcPvpBattleEndNotify() {}
    
    private PvpBattleEndInfo _BattleEndInfo = null;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"BattleEndInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public PvpBattleEndInfo BattleEndInfo
    {
      get { return _BattleEndInfo; }
      set { _BattleEndInfo = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PvpRpcMatchSucessNotify")]
  public partial class PvpRpcMatchSucessNotify : global::ProtoBuf.IExtensible
  {
    public PvpRpcMatchSucessNotify() {}
    
    private readonly global::System.Collections.Generic.List<PvpPlayerInfo> _LeftTeam = new global::System.Collections.Generic.List<PvpPlayerInfo>();
    [global::ProtoBuf.ProtoMember(1, Name=@"LeftTeam", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<PvpPlayerInfo> LeftTeam
    {
      get { return _LeftTeam; }
    }
  
    private readonly global::System.Collections.Generic.List<PvpPlayerInfo> _RightTeam = new global::System.Collections.Generic.List<PvpPlayerInfo>();
    [global::ProtoBuf.ProtoMember(2, Name=@"RightTeam", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<PvpPlayerInfo> RightTeam
    {
      get { return _RightTeam; }
    }
  
    private int _Time = (int)-1;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Time", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int Time
    {
      get { return _Time; }
      set { _Time = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PvpRpcRankChangeNotify")]
  public partial class PvpRpcRankChangeNotify : global::ProtoBuf.IExtensible
  {
    public PvpRpcRankChangeNotify() {}
    
    private int _PvpType = (int)-1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"PvpType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int PvpType
    {
      get { return _PvpType; }
      set { _PvpType = value; }
    }
    private int _BeforeRank = (int)-1;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"BeforeRank", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int BeforeRank
    {
      get { return _BeforeRank; }
      set { _BeforeRank = value; }
    }
    private int _AfterRank = (int)-1;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"AfterRank", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int AfterRank
    {
      get { return _AfterRank; }
      set { _AfterRank = value; }
    }
    private int _BeforeStar = (int)-1;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"BeforeStar", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int BeforeStar
    {
      get { return _BeforeStar; }
      set { _BeforeStar = value; }
    }
    private int _AfterStar = (int)-1;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"AfterStar", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int AfterStar
    {
      get { return _AfterStar; }
      set { _AfterStar = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PvpRpcReturnLastSceneAsk")]
  public partial class PvpRpcReturnLastSceneAsk : global::ProtoBuf.IExtensible
  {
    public PvpRpcReturnLastSceneAsk() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PvpRpcReturnLastSceneReply")]
  public partial class PvpRpcReturnLastSceneReply : global::ProtoBuf.IExtensible
  {
    public PvpRpcReturnLastSceneReply() {}
    
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
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PvpRpcArenaStartTimeNotify")]
  public partial class PvpRpcArenaStartTimeNotify : global::ProtoBuf.IExtensible
  {
    public PvpRpcArenaStartTimeNotify() {}
    
    private int _NeedTime = (int)-1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"NeedTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int NeedTime
    {
      get { return _NeedTime; }
      set { _NeedTime = value; }
    }
    private int _TimeStamp = (int)-1;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"TimeStamp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int TimeStamp
    {
      get { return _TimeStamp; }
      set { _TimeStamp = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PvpRpcUpdateKillCountNotify")]
  public partial class PvpRpcUpdateKillCountNotify : global::ProtoBuf.IExtensible
  {
    public PvpRpcUpdateKillCountNotify() {}
    
    private int _LeftTeamKill = (int)-1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"LeftTeamKill", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int LeftTeamKill
    {
      get { return _LeftTeamKill; }
      set { _LeftTeamKill = value; }
    }
    private int _RightTeamKill = (int)-1;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"RightTeamKill", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int RightTeamKill
    {
      get { return _RightTeamKill; }
      set { _RightTeamKill = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PvpRpcArenaLeftTimeNotify")]
  public partial class PvpRpcArenaLeftTimeNotify : global::ProtoBuf.IExtensible
  {
    public PvpRpcArenaLeftTimeNotify() {}
    
    private int _LeftTime = (int)-1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"LeftTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int LeftTime
    {
      get { return _LeftTime; }
      set { _LeftTime = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PvpRpcLastRankAsk")]
  public partial class PvpRpcLastRankAsk : global::ProtoBuf.IExtensible
  {
    public PvpRpcLastRankAsk() {}
    
    private int _PvpType = (int)-1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"PvpType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int PvpType
    {
      get { return _PvpType; }
      set { _PvpType = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PvpRpcLastRankReply")]
  public partial class PvpRpcLastRankReply : global::ProtoBuf.IExtensible
  {
    public PvpRpcLastRankReply() {}
    
    private int _Result = (int)-1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int Result
    {
      get { return _Result; }
      set { _Result = value; }
    }
    private readonly global::System.Collections.Generic.List<PvpPlayerInfo> _RankList = new global::System.Collections.Generic.List<PvpPlayerInfo>();
    [global::ProtoBuf.ProtoMember(2, Name=@"RankList", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<PvpPlayerInfo> RankList
    {
      get { return _RankList; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PvpRpcNewSeasonNotify")]
  public partial class PvpRpcNewSeasonNotify : global::ProtoBuf.IExtensible
  {
    public PvpRpcNewSeasonNotify() {}
    
    private int _LastRank = (int)-1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"LastRank", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int LastRank
    {
      get { return _LastRank; }
      set { _LastRank = value; }
    }
    private int _LastStar = (int)-1;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"LastStar", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int LastStar
    {
      get { return _LastStar; }
      set { _LastStar = value; }
    }
    private int _LastRanking = (int)-1;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"LastRanking", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int LastRanking
    {
      get { return _LastRanking; }
      set { _LastRanking = value; }
    }
    private readonly global::System.Collections.Generic.List<PvpBattleRewardInfo> _RewardList = new global::System.Collections.Generic.List<PvpBattleRewardInfo>();
    [global::ProtoBuf.ProtoMember(4, Name=@"RewardList", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<PvpBattleRewardInfo> RewardList
    {
      get { return _RewardList; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PvpRpcGetSeasonRewardAsk")]
  public partial class PvpRpcGetSeasonRewardAsk : global::ProtoBuf.IExtensible
  {
    public PvpRpcGetSeasonRewardAsk() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PvpRpcGetSeasonRewardReply")]
  public partial class PvpRpcGetSeasonRewardReply : global::ProtoBuf.IExtensible
  {
    public PvpRpcGetSeasonRewardReply() {}
    
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
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PvpRpcPvpBattleInfoSyncAsk")]
  public partial class PvpRpcPvpBattleInfoSyncAsk : global::ProtoBuf.IExtensible
  {
    public PvpRpcPvpBattleInfoSyncAsk() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PvpRpcPvpBattleInfoSyncReply")]
  public partial class PvpRpcPvpBattleInfoSyncReply : global::ProtoBuf.IExtensible
  {
    public PvpRpcPvpBattleInfoSyncReply() {}
    
    private int _Result = (int)-1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int Result
    {
      get { return _Result; }
      set { _Result = value; }
    }
    private PvpBattleInfo _BattleInfo = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"BattleInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public PvpBattleInfo BattleInfo
    {
      get { return _BattleInfo; }
      set { _BattleInfo = value; }
    }
    private int _Season = (int)-1;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Season", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int Season
    {
      get { return _Season; }
      set { _Season = value; }
    }
    private int _RankIndex = (int)-1;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"RankIndex", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int RankIndex
    {
      get { return _RankIndex; }
      set { _RankIndex = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PvpRpcReconnectNotify")]
  public partial class PvpRpcReconnectNotify : global::ProtoBuf.IExtensible
  {
    public PvpRpcReconnectNotify() {}
    
    private int _NeedKill = (int)-1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"NeedKill", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int NeedKill
    {
      get { return _NeedKill; }
      set { _NeedKill = value; }
    }
    private int _ArenaState = (int)-1;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"ArenaState", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int ArenaState
    {
      get { return _ArenaState; }
      set { _ArenaState = value; }
    }
    private int _LeftTime = (int)-1;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"LeftTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int LeftTime
    {
      get { return _LeftTime; }
      set { _LeftTime = value; }
    }
    private int _LeftKill = (int)-1;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"LeftKill", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int LeftKill
    {
      get { return _LeftKill; }
      set { _LeftKill = value; }
    }
    private int _RightKill = (int)-1;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"RightKill", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int RightKill
    {
      get { return _RightKill; }
      set { _RightKill = value; }
    }
    private int _Camp = (int)-1;
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"Camp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int Camp
    {
      get { return _Camp; }
      set { _Camp = value; }
    }
    private int _TimeStamp = (int)-1;
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"TimeStamp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int TimeStamp
    {
      get { return _TimeStamp; }
      set { _TimeStamp = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PvpRpcGetRewardAsk")]
  public partial class PvpRpcGetRewardAsk : global::ProtoBuf.IExtensible
  {
    public PvpRpcGetRewardAsk() {}
    
    private int _PvPType = (int)-1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"PvPType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int PvPType
    {
      get { return _PvPType; }
      set { _PvPType = value; }
    }
    private int _Rank = (int)-1;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Rank", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int Rank
    {
      get { return _Rank; }
      set { _Rank = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PvpRpcGetRewardReply")]
  public partial class PvpRpcGetRewardReply : global::ProtoBuf.IExtensible
  {
    public PvpRpcGetRewardReply() {}
    
    private int _Result = (int)-1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int Result
    {
      get { return _Result; }
      set { _Result = value; }
    }
    private readonly global::System.Collections.Generic.List<int> _RewardList = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(2, Name=@"RewardList", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<int> RewardList
    {
      get { return _RewardList; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}