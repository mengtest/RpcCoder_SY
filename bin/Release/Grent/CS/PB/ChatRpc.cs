//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: ChatRpc.proto
// Note: requires additional types generated from: PublicStruct.proto
namespace GenPB
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ChatRpcChatAsk")]
  public partial class ChatRpcChatAsk : global::ProtoBuf.IExtensible
  {
    public ChatRpcChatAsk() {}
    
    private ChatMsg _Chat_msg = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Chat_msg", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public ChatMsg Chat_msg
    {
      get { return _Chat_msg; }
      set { _Chat_msg = value; }
    }
    private int _Chat_channel = (int)-1;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Chat_channel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)-1)]
    public int Chat_channel
    {
      get { return _Chat_channel; }
      set { _Chat_channel = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ChatRpcChatReply")]
  public partial class ChatRpcChatReply : global::ProtoBuf.IExtensible
  {
    public ChatRpcChatReply() {}
    
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
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ChatRpcPushChatUpdatesNotify")]
  public partial class ChatRpcPushChatUpdatesNotify : global::ProtoBuf.IExtensible
  {
    public ChatRpcPushChatUpdatesNotify() {}
    
    private readonly global::System.Collections.Generic.List<ChatChannelData> _Chat_channels = new global::System.Collections.Generic.List<ChatChannelData>();
    [global::ProtoBuf.ProtoMember(1, Name=@"Chat_channels", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<ChatChannelData> Chat_channels
    {
      get { return _Chat_channels; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ChatRpcPushMarqueeNotify")]
  public partial class ChatRpcPushMarqueeNotify : global::ProtoBuf.IExtensible
  {
    public ChatRpcPushMarqueeNotify() {}
    
    private readonly global::System.Collections.Generic.List<string> _Marquee = new global::System.Collections.Generic.List<string>();
    [global::ProtoBuf.ProtoMember(1, Name=@"Marquee", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<string> Marquee
    {
      get { return _Marquee; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ChatRpcSayNotify")]
  public partial class ChatRpcSayNotify : global::ProtoBuf.IExtensible
  {
    public ChatRpcSayNotify() {}
    
    private int _ObjId = (int)0;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"ObjId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int ObjId
    {
      get { return _ObjId; }
      set { _ObjId = value; }
    }
    private int _ChatId = (int)0;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"ChatId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int ChatId
    {
      get { return _ChatId; }
      set { _ChatId = value; }
    }
    private int _Duration = (int)0;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Duration", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int Duration
    {
      get { return _Duration; }
      set { _Duration = value; }
    }
    private int _ChatType = (int)0;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"ChatType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int ChatType
    {
      get { return _ChatType; }
      set { _ChatType = value; }
    }
    private int _Interval = (int)0;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"Interval", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((int)0)]
    public int Interval
    {
      get { return _Interval; }
      set { _Interval = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}