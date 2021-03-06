//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: WorldBossRpc.proto
// Note: requires additional types generated from: PublicStruct.proto
namespace GenPB
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"WorldBossRpcWorldBossInfoAsk")]
  public partial class WorldBossRpcWorldBossInfoAsk : global::ProtoBuf.IExtensible
  {
    public WorldBossRpcWorldBossInfoAsk() {}
    
    private int _BossID = (int)-1;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"BossID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int BossID
    {
      get { return _BossID; }
      set { _BossID = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"WorldBossRpcWorldBossInfoReply")]
  public partial class WorldBossRpcWorldBossInfoReply : global::ProtoBuf.IExtensible
  {
    public WorldBossRpcWorldBossInfoReply() {}
    
    private int _Result = (int)-1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int Result
    {
      get { return _Result; }
      set { _Result = value; }
    }
    private readonly global::System.Collections.Generic.List<WorldBossInfo> _WorldBossInfos = new global::System.Collections.Generic.List<WorldBossInfo>();
    [global::ProtoBuf.ProtoMember(2, Name=@"WorldBossInfos", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<WorldBossInfo> WorldBossInfos
    {
      get { return _WorldBossInfos; }
    }
  
    private int _BossID = (int)-1;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"BossID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int BossID
    {
      get { return _BossID; }
      set { _BossID = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"WorldBossRpcWorldBossRankInfoAsk")]
  public partial class WorldBossRpcWorldBossRankInfoAsk : global::ProtoBuf.IExtensible
  {
    public WorldBossRpcWorldBossRankInfoAsk() {}
    
    private int _BossID = (int)-1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"BossID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int BossID
    {
      get { return _BossID; }
      set { _BossID = value; }
    }
    private int _Occupation = (int)-1;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Occupation", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int Occupation
    {
      get { return _Occupation; }
      set { _Occupation = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"WorldBossRpcWorldBossRankInfoReply")]
  public partial class WorldBossRpcWorldBossRankInfoReply : global::ProtoBuf.IExtensible
  {
    public WorldBossRpcWorldBossRankInfoReply() {}
    
    private int _Result = (int)-1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int Result
    {
      get { return _Result; }
      set { _Result = value; }
    }
    private readonly global::System.Collections.Generic.List<WorldBossRankInfo> _RankInfo = new global::System.Collections.Generic.List<WorldBossRankInfo>();
    [global::ProtoBuf.ProtoMember(2, Name=@"RankInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<WorldBossRankInfo> RankInfo
    {
      get { return _RankInfo; }
    }
  
    private string _LastKillName = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"LastKillName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string LastKillName
    {
      get { return _LastKillName; }
      set { _LastKillName = value; }
    }
    private string _MaxDamageName = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"MaxDamageName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string MaxDamageName
    {
      get { return _MaxDamageName; }
      set { _MaxDamageName = value; }
    }
    private int _MyRank = (int)-1;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"MyRank", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int MyRank
    {
      get { return _MyRank; }
      set { _MyRank = value; }
    }
    private int _Occupation = (int)-1;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"Occupation", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int Occupation
    {
      get { return _Occupation; }
      set { _Occupation = value; }
    }
    private int _BossID = (int)-1;
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"BossID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int BossID
    {
      get { return _BossID; }
      set { _BossID = value; }
    }
    private int _MyOccupationRank = (int)-1;
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"MyOccupationRank", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int MyOccupationRank
    {
      get { return _MyOccupationRank; }
      set { _MyOccupationRank = value; }
    }
    private int _MyScore = (int)-1;
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"MyScore", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int MyScore
    {
      get { return _MyScore; }
      set { _MyScore = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}