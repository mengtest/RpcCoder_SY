//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: PetRpc.proto
// Note: requires additional types generated from: PublicStruct.proto
namespace GenPB
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PetRpcPetSyncAsk")]
  public partial class PetRpcPetSyncAsk : global::ProtoBuf.IExtensible
  {
    public PetRpcPetSyncAsk() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PetRpcPetSyncReply")]
  public partial class PetRpcPetSyncReply : global::ProtoBuf.IExtensible
  {
    public PetRpcPetSyncReply() {}
    
    private int _Result = (int)-1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int Result
    {
      get { return _Result; }
      set { _Result = value; }
    }
    private ItemData _ItemData = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"ItemData", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public ItemData ItemData
    {
      get { return _ItemData; }
      set { _ItemData = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PetRpcUnSummonAsk")]
  public partial class PetRpcUnSummonAsk : global::ProtoBuf.IExtensible
  {
    public PetRpcUnSummonAsk() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PetRpcUnSummonReply")]
  public partial class PetRpcUnSummonReply : global::ProtoBuf.IExtensible
  {
    public PetRpcUnSummonReply() {}
    
    private int _Result = (int)-1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int Result
    {
      get { return _Result; }
      set { _Result = value; }
    }
    private ItemObj _ItemObj = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"ItemObj", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public ItemObj ItemObj
    {
      get { return _ItemObj; }
      set { _ItemObj = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PetRpcLevelUpgradeAsk")]
  public partial class PetRpcLevelUpgradeAsk : global::ProtoBuf.IExtensible
  {
    public PetRpcLevelUpgradeAsk() {}
    
    private ulong _Guid = (ulong)0;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Guid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((ulong)0)]
    public ulong Guid
    {
      get { return _Guid; }
      set { _Guid = value; }
    }
    private readonly global::System.Collections.Generic.List<int> _ItemCount = new global::System.Collections.Generic.List<int>();
    [global::ProtoBuf.ProtoMember(3, Name=@"ItemCount", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<int> ItemCount
    {
      get { return _ItemCount; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PetRpcLevelUpgradeReply")]
  public partial class PetRpcLevelUpgradeReply : global::ProtoBuf.IExtensible
  {
    public PetRpcLevelUpgradeReply() {}
    
    private int _Result = (int)-1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int Result
    {
      get { return _Result; }
      set { _Result = value; }
    }
    private ItemData _ItemData = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"ItemData", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public ItemData ItemData
    {
      get { return _ItemData; }
      set { _ItemData = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PetRpcStarUpgradeAsk")]
  public partial class PetRpcStarUpgradeAsk : global::ProtoBuf.IExtensible
  {
    public PetRpcStarUpgradeAsk() {}
    
    private ulong _Guid = (ulong)0;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Guid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((ulong)0)]
    public ulong Guid
    {
      get { return _Guid; }
      set { _Guid = value; }
    }
    private ulong _UseGuid = (ulong)0;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"UseGuid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((ulong)0)]
    public ulong UseGuid
    {
      get { return _UseGuid; }
      set { _UseGuid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PetRpcStarUpgradeReply")]
  public partial class PetRpcStarUpgradeReply : global::ProtoBuf.IExtensible
  {
    public PetRpcStarUpgradeReply() {}
    
    private int _Result = (int)-1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int Result
    {
      get { return _Result; }
      set { _Result = value; }
    }
    private ItemData _ItemData = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"ItemData", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public ItemData ItemData
    {
      get { return _ItemData; }
      set { _ItemData = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PetRpcChangeNameAsk")]
  public partial class PetRpcChangeNameAsk : global::ProtoBuf.IExtensible
  {
    public PetRpcChangeNameAsk() {}
    
    private ulong _Guid = (ulong)0;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Guid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((ulong)0)]
    public ulong Guid
    {
      get { return _Guid; }
      set { _Guid = value; }
    }
    private string _NewName = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"NewName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string NewName
    {
      get { return _NewName; }
      set { _NewName = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PetRpcChangeNameReply")]
  public partial class PetRpcChangeNameReply : global::ProtoBuf.IExtensible
  {
    public PetRpcChangeNameReply() {}
    
    private int _Result = (int)-1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int Result
    {
      get { return _Result; }
      set { _Result = value; }
    }
    private string _Name = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Name
    {
      get { return _Name; }
      set { _Name = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PetRpcInheritAsk")]
  public partial class PetRpcInheritAsk : global::ProtoBuf.IExtensible
  {
    public PetRpcInheritAsk() {}
    
    private ulong _Guid = (ulong)0;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Guid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((ulong)0)]
    public ulong Guid
    {
      get { return _Guid; }
      set { _Guid = value; }
    }
    private ulong _UseGuid = (ulong)0;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"UseGuid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((ulong)0)]
    public ulong UseGuid
    {
      get { return _UseGuid; }
      set { _UseGuid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PetRpcInheritReply")]
  public partial class PetRpcInheritReply : global::ProtoBuf.IExtensible
  {
    public PetRpcInheritReply() {}
    
    private int _Result = (int)-1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int Result
    {
      get { return _Result; }
      set { _Result = value; }
    }
    private ItemData _ItemData = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"ItemData", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public ItemData ItemData
    {
      get { return _ItemData; }
      set { _ItemData = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PetRpcSkillInheritAsk")]
  public partial class PetRpcSkillInheritAsk : global::ProtoBuf.IExtensible
  {
    public PetRpcSkillInheritAsk() {}
    
    private ulong _Guid = (ulong)0;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Guid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((ulong)0)]
    public ulong Guid
    {
      get { return _Guid; }
      set { _Guid = value; }
    }
    private ulong _UseGuid = (ulong)0;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"UseGuid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((ulong)0)]
    public ulong UseGuid
    {
      get { return _UseGuid; }
      set { _UseGuid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PetRpcSkillInheritReply")]
  public partial class PetRpcSkillInheritReply : global::ProtoBuf.IExtensible
  {
    public PetRpcSkillInheritReply() {}
    
    private int _Result = (int)-1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int Result
    {
      get { return _Result; }
      set { _Result = value; }
    }
    private ItemData _ItemData = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"ItemData", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public ItemData ItemData
    {
      get { return _ItemData; }
      set { _ItemData = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PetRpcPassiveSkillsAsk")]
  public partial class PetRpcPassiveSkillsAsk : global::ProtoBuf.IExtensible
  {
    public PetRpcPassiveSkillsAsk() {}
    
    private ulong _Guid = (ulong)0;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Guid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((ulong)0)]
    public ulong Guid
    {
      get { return _Guid; }
      set { _Guid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PetRpcPassiveSkillsReply")]
  public partial class PetRpcPassiveSkillsReply : global::ProtoBuf.IExtensible
  {
    public PetRpcPassiveSkillsReply() {}
    
    private int _Result = (int)-1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int Result
    {
      get { return _Result; }
      set { _Result = value; }
    }
    private readonly global::System.Collections.Generic.List<PetSkill> _Skills = new global::System.Collections.Generic.List<PetSkill>();
    [global::ProtoBuf.ProtoMember(2, Name=@"Skills", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<PetSkill> Skills
    {
      get { return _Skills; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PetRpcStudySkillAsk")]
  public partial class PetRpcStudySkillAsk : global::ProtoBuf.IExtensible
  {
    public PetRpcStudySkillAsk() {}
    
    private ulong _Guid = (ulong)0;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Guid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((ulong)0)]
    public ulong Guid
    {
      get { return _Guid; }
      set { _Guid = value; }
    }
    private int _ItemId = (int)-1;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"ItemId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int ItemId
    {
      get { return _ItemId; }
      set { _ItemId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PetRpcStudySkillReply")]
  public partial class PetRpcStudySkillReply : global::ProtoBuf.IExtensible
  {
    public PetRpcStudySkillReply() {}
    
    private int _Result = (int)-1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int Result
    {
      get { return _Result; }
      set { _Result = value; }
    }
    private ItemData _ItemData = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"ItemData", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public ItemData ItemData
    {
      get { return _ItemData; }
      set { _ItemData = value; }
    }
    private int _ReplacedSkillId = (int)-1;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"ReplacedSkillId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int ReplacedSkillId
    {
      get { return _ReplacedSkillId; }
      set { _ReplacedSkillId = value; }
    }
    private int _Index = (int)-1;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"Index", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int Index
    {
      get { return _Index; }
      set { _Index = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PetRpcLockSkillAsk")]
  public partial class PetRpcLockSkillAsk : global::ProtoBuf.IExtensible
  {
    public PetRpcLockSkillAsk() {}
    
    private ulong _Guid = (ulong)0;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Guid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((ulong)0)]
    public ulong Guid
    {
      get { return _Guid; }
      set { _Guid = value; }
    }
    private int _SkillId = (int)-1;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"SkillId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int SkillId
    {
      get { return _SkillId; }
      set { _SkillId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PetRpcLockSkillReply")]
  public partial class PetRpcLockSkillReply : global::ProtoBuf.IExtensible
  {
    public PetRpcLockSkillReply() {}
    
    private int _Result = (int)-1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int Result
    {
      get { return _Result; }
      set { _Result = value; }
    }
    private ItemData _ItemData = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"ItemData", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public ItemData ItemData
    {
      get { return _ItemData; }
      set { _ItemData = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PetRpcUnLockSkillAsk")]
  public partial class PetRpcUnLockSkillAsk : global::ProtoBuf.IExtensible
  {
    public PetRpcUnLockSkillAsk() {}
    
    private ulong _Guid = (ulong)0;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Guid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((ulong)0)]
    public ulong Guid
    {
      get { return _Guid; }
      set { _Guid = value; }
    }
    private int _SkillId = (int)-1;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"SkillId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int SkillId
    {
      get { return _SkillId; }
      set { _SkillId = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PetRpcUnLockSkillReply")]
  public partial class PetRpcUnLockSkillReply : global::ProtoBuf.IExtensible
  {
    public PetRpcUnLockSkillReply() {}
    
    private int _Result = (int)-1;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int Result
    {
      get { return _Result; }
      set { _Result = value; }
    }
    private ItemData _ItemData = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"ItemData", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public ItemData ItemData
    {
      get { return _ItemData; }
      set { _ItemData = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}