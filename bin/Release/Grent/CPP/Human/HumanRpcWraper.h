/********************************************************************************************
* Copyright (C), 2011-2025, AGAN Tech. Co., Ltd.
* FileName:     RpcWraperHuman.h
* Author:       甘业清
* Description:  玩家模块RPC通信参数的类封装
* Version:      1.0
* History:
* <author>  <time>   <version >   <desc>
* 
********************************************************************************************/

#ifndef __RPC_WRAPER_HUMAN_H
#define __RPC_WRAPER_HUMAN_H

#include "BASE.h"
#include "PublicStructWraper.h"
#include "DataWraperInterface.h"
#include "HumanRpc.pb.h"



//玩家模块类的枚举定义
enum ConstHumanE
{
	MODULE_ID_HUMAN                              = 4,	//玩家模块模块ID
	RPC_CODE_HUMAN_MOVE_REQUEST                  = 451,	//玩家模块-->human move-->请求
	RPC_CODE_HUMAN_STOPMOVE_REQUEST              = 452,	//玩家模块-->客户端停止移动-->请求
	RPC_CODE_HUMAN_MOVECHECK_NOTIFY              = 453,	//玩家模块-->移动检测-->通知
	RPC_CODE_HUMAN_RESPAWN_REQUEST               = 454,	//玩家模块-->复活-->请求
	RPC_CODE_HUMAN_RESPAWNOTHER_NOTIFY           = 455,	//玩家模块-->复活其他玩家通知-->通知
	RPC_CODE_HUMAN_MOVEPOS_REQUEST               = 456,	//玩家模块-->MovePos-->请求
	RPC_CODE_HUMAN_ROLEDIE_NOTIFY                = 457,	//玩家模块-->死亡通知-->通知
	RPC_CODE_HUMAN_CHANGEANIMATIONSTATE_NOTIFY   = 458,	//玩家模块-->改变动画状态 纯客户端-->通知
	RPC_CODE_HUMAN_FUNCNOTICE_REQUEST            = 459,	//玩家模块-->玩家功能预告-->请求
	RPC_CODE_HUMAN_FUNCNOTICECHANGE_REQUEST      = 460,	//玩家模块-->玩家功能预告-->请求
	RPC_CODE_HUMAN_CLIENTATTRIBUTES_NOTIFY       = 461,	//玩家模块-->客户端属性双向通知-->通知


};


//改变动画状态 纯客户端通知封装类
class HumanRpcChangeAnimationStateNotifyWraper : public DataWraperInterface 
{
public:
	//构造函数
	HumanRpcChangeAnimationStateNotifyWraper()
	{
		
		m_AnimationState = false;

	}
	//赋值构造函数
	HumanRpcChangeAnimationStateNotifyWraper(const HumanRpcChangeAnimationStateNotify& v){ Init(v); }
	//等号重载函数
	void operator = (const HumanRpcChangeAnimationStateNotify& v){ Init(v); }
 	//转化成Protobuffer类型函数
	HumanRpcChangeAnimationStateNotify ToPB() const
	{
		HumanRpcChangeAnimationStateNotify v;
		v.set_animationstate( m_AnimationState );

		return v;
	}
	//获取Protobuffer序列化后大小函数
	int ByteSize() const { return ToPB().ByteSize();}
	//Protobuffer序列化到缓冲区
	bool SerializeToArray( void* data, int size ) const
	{
		return ToPB().SerializeToArray(data,size);
	}
	//Protobuffer序列化到字符串
	string SerializeAsString() const
	{
		return ToPB().SerializeAsString();
	}
	//Protobuffer从字符串进行反序列化
	bool ParseFromString(const string& v)
	{
		return ParseFromArray(v.data(),v.size());
	}
	//Protobuffer从缓冲区进行反序列化
	bool ParseFromArray(const void* data, int size)
	{
		HumanRpcChangeAnimationStateNotify pb;
		if(!pb.ParseFromArray(data,size)){return false;}
		Init(pb);
		return true;
	}

	string HtmlDescHeader()
	{
		string htmlBuff = "<div style=\"padding-left:30px\">\r\n";

		
		htmlBuff += "</div>\r\n";
		return htmlBuff;
	}

	string ToHtml()
	{
		string htmlBuff = "<div style=\"padding-left:30px\">\r\n";
		TStr tmpLine;

		
		htmlBuff += "</div>\r\n";
		return htmlBuff;
	}


private:
	//从Protobuffer类型初始化
	void Init(const HumanRpcChangeAnimationStateNotify& v)
	{
		m_AnimationState = v.animationstate();

	}

private:
	//动画状态 具体值由客户端定
	bool m_AnimationState;
public:
	void SetAnimationState( bool v)
	{
		m_AnimationState=v;
	}
	bool GetAnimationState()
	{
		return m_AnimationState;
	}
	bool GetAnimationState() const
	{
		return m_AnimationState;
	}

};
//玩家功能预告请求封装类
class HumanRpcFuncNoticeAskWraper : public DataWraperInterface 
{
public:
	//构造函数
	HumanRpcFuncNoticeAskWraper()
	{
		

	}
	//赋值构造函数
	HumanRpcFuncNoticeAskWraper(const HumanRpcFuncNoticeAsk& v){ Init(v); }
	//等号重载函数
	void operator = (const HumanRpcFuncNoticeAsk& v){ Init(v); }
 	//转化成Protobuffer类型函数
	HumanRpcFuncNoticeAsk ToPB() const
	{
		HumanRpcFuncNoticeAsk v;

		return v;
	}
	//获取Protobuffer序列化后大小函数
	int ByteSize() const { return ToPB().ByteSize();}
	//Protobuffer序列化到缓冲区
	bool SerializeToArray( void* data, int size ) const
	{
		return ToPB().SerializeToArray(data,size);
	}
	//Protobuffer序列化到字符串
	string SerializeAsString() const
	{
		return ToPB().SerializeAsString();
	}
	//Protobuffer从字符串进行反序列化
	bool ParseFromString(const string& v)
	{
		return ParseFromArray(v.data(),v.size());
	}
	//Protobuffer从缓冲区进行反序列化
	bool ParseFromArray(const void* data, int size)
	{
		HumanRpcFuncNoticeAsk pb;
		if(!pb.ParseFromArray(data,size)){return false;}
		Init(pb);
		return true;
	}

	string HtmlDescHeader()
	{
		string htmlBuff = "<div style=\"padding-left:30px\">\r\n";

		
		htmlBuff += "</div>\r\n";
		return htmlBuff;
	}

	string ToHtml()
	{
		string htmlBuff = "<div style=\"padding-left:30px\">\r\n";
		TStr tmpLine;

		
		htmlBuff += "</div>\r\n";
		return htmlBuff;
	}


private:
	//从Protobuffer类型初始化
	void Init(const HumanRpcFuncNoticeAsk& v)
	{

	}


};
//MovePos回应封装类
class HumanRpcMovePosReplyWraper : public DataWraperInterface 
{
public:
	//构造函数
	HumanRpcMovePosReplyWraper()
	{
		
		m_Result = -1;
		m_Pos = Vector3IntWraper();
		m_Dir = -1;
		m_ObjId = -1;

	}
	//赋值构造函数
	HumanRpcMovePosReplyWraper(const HumanRpcMovePosReply& v){ Init(v); }
	//等号重载函数
	void operator = (const HumanRpcMovePosReply& v){ Init(v); }
 	//转化成Protobuffer类型函数
	HumanRpcMovePosReply ToPB() const
	{
		HumanRpcMovePosReply v;
		v.set_result( m_Result );
		*v.mutable_pos()= m_Pos.ToPB();
		v.set_dir( m_Dir );
		v.set_objid( m_ObjId );

		return v;
	}
	//获取Protobuffer序列化后大小函数
	int ByteSize() const { return ToPB().ByteSize();}
	//Protobuffer序列化到缓冲区
	bool SerializeToArray( void* data, int size ) const
	{
		return ToPB().SerializeToArray(data,size);
	}
	//Protobuffer序列化到字符串
	string SerializeAsString() const
	{
		return ToPB().SerializeAsString();
	}
	//Protobuffer从字符串进行反序列化
	bool ParseFromString(const string& v)
	{
		return ParseFromArray(v.data(),v.size());
	}
	//Protobuffer从缓冲区进行反序列化
	bool ParseFromArray(const void* data, int size)
	{
		HumanRpcMovePosReply pb;
		if(!pb.ParseFromArray(data,size)){return false;}
		Init(pb);
		return true;
	}

	string HtmlDescHeader()
	{
		string htmlBuff = "<div style=\"padding-left:30px\">\r\n";

		
		htmlBuff += "</div>\r\n";
		return htmlBuff;
	}

	string ToHtml()
	{
		string htmlBuff = "<div style=\"padding-left:30px\">\r\n";
		TStr tmpLine;

		
		htmlBuff += "</div>\r\n";
		return htmlBuff;
	}


private:
	//从Protobuffer类型初始化
	void Init(const HumanRpcMovePosReply& v)
	{
		m_Result = v.result();
		m_Pos = v.pos();
		m_Dir = v.dir();
		m_ObjId = v.objid();

	}

private:
	//返回结果
	INT32 m_Result;
public:
	void SetResult( INT32 v)
	{
		m_Result=v;
	}
	INT32 GetResult()
	{
		return m_Result;
	}
	INT32 GetResult() const
	{
		return m_Result;
	}
private:
	//PosList
	Vector3IntWraper m_Pos;
public:
	void SetPos( const Vector3IntWraper& v)
	{
		m_Pos=v;
	}
	Vector3IntWraper GetPos()
	{
		return m_Pos;
	}
	Vector3IntWraper GetPos() const
	{
		return m_Pos;
	}
private:
	//Dir
	float m_Dir;
public:
	void SetDir( float v)
	{
		m_Dir=v;
	}
	float GetDir()
	{
		return m_Dir;
	}
	float GetDir() const
	{
		return m_Dir;
	}
private:
	//目标ID
	INT32 m_ObjId;
public:
	void SetObjId( INT32 v)
	{
		m_ObjId=v;
	}
	INT32 GetObjId()
	{
		return m_ObjId;
	}
	INT32 GetObjId() const
	{
		return m_ObjId;
	}

};
//死亡通知通知封装类
class HumanRpcRoleDieNotifyWraper : public DataWraperInterface 
{
public:
	//构造函数
	HumanRpcRoleDieNotifyWraper()
	{
		
		m_KillerGuid = -1;
		m_KillerName = "";
		m_KillerType = -1;
		m_RevieCDTime = -1;

	}
	//赋值构造函数
	HumanRpcRoleDieNotifyWraper(const HumanRpcRoleDieNotify& v){ Init(v); }
	//等号重载函数
	void operator = (const HumanRpcRoleDieNotify& v){ Init(v); }
 	//转化成Protobuffer类型函数
	HumanRpcRoleDieNotify ToPB() const
	{
		HumanRpcRoleDieNotify v;
		v.set_killerguid( m_KillerGuid );
		v.set_killername( m_KillerName );
		v.set_killertype( m_KillerType );
		v.set_reviecdtime( m_RevieCDTime );

		return v;
	}
	//获取Protobuffer序列化后大小函数
	int ByteSize() const { return ToPB().ByteSize();}
	//Protobuffer序列化到缓冲区
	bool SerializeToArray( void* data, int size ) const
	{
		return ToPB().SerializeToArray(data,size);
	}
	//Protobuffer序列化到字符串
	string SerializeAsString() const
	{
		return ToPB().SerializeAsString();
	}
	//Protobuffer从字符串进行反序列化
	bool ParseFromString(const string& v)
	{
		return ParseFromArray(v.data(),v.size());
	}
	//Protobuffer从缓冲区进行反序列化
	bool ParseFromArray(const void* data, int size)
	{
		HumanRpcRoleDieNotify pb;
		if(!pb.ParseFromArray(data,size)){return false;}
		Init(pb);
		return true;
	}

	string HtmlDescHeader()
	{
		string htmlBuff = "<div style=\"padding-left:30px\">\r\n";

		
		htmlBuff += "</div>\r\n";
		return htmlBuff;
	}

	string ToHtml()
	{
		string htmlBuff = "<div style=\"padding-left:30px\">\r\n";
		TStr tmpLine;

		
		htmlBuff += "</div>\r\n";
		return htmlBuff;
	}


private:
	//从Protobuffer类型初始化
	void Init(const HumanRpcRoleDieNotify& v)
	{
		m_KillerGuid = v.killerguid();
		m_KillerName = v.killername();
		m_KillerType = v.killertype();
		m_RevieCDTime = v.reviecdtime();

	}

private:
	//击杀者ID
	int64_t m_KillerGuid;
public:
	void SetKillerGuid( int64_t v)
	{
		m_KillerGuid=v;
	}
	int64_t GetKillerGuid()
	{
		return m_KillerGuid;
	}
	int64_t GetKillerGuid() const
	{
		return m_KillerGuid;
	}
private:
	//击杀者名字
	string m_KillerName;
public:
	void SetKillerName( const string& v)
	{
		m_KillerName=v;
	}
	string GetKillerName()
	{
		return m_KillerName;
	}
	string GetKillerName() const
	{
		return m_KillerName;
	}
private:
	//击杀者类型
	INT32 m_KillerType;
public:
	void SetKillerType( INT32 v)
	{
		m_KillerType=v;
	}
	INT32 GetKillerType()
	{
		return m_KillerType;
	}
	INT32 GetKillerType() const
	{
		return m_KillerType;
	}
private:
	//就近复活CD时间
	INT32 m_RevieCDTime;
public:
	void SetRevieCDTime( INT32 v)
	{
		m_RevieCDTime=v;
	}
	INT32 GetRevieCDTime()
	{
		return m_RevieCDTime;
	}
	INT32 GetRevieCDTime() const
	{
		return m_RevieCDTime;
	}

};
//玩家功能预告回应封装类
class HumanRpcFuncNoticeChangeReplyWraper : public DataWraperInterface 
{
public:
	//构造函数
	HumanRpcFuncNoticeChangeReplyWraper()
	{
		
		m_Result = -1;

	}
	//赋值构造函数
	HumanRpcFuncNoticeChangeReplyWraper(const HumanRpcFuncNoticeChangeReply& v){ Init(v); }
	//等号重载函数
	void operator = (const HumanRpcFuncNoticeChangeReply& v){ Init(v); }
 	//转化成Protobuffer类型函数
	HumanRpcFuncNoticeChangeReply ToPB() const
	{
		HumanRpcFuncNoticeChangeReply v;
		v.set_result( m_Result );

		return v;
	}
	//获取Protobuffer序列化后大小函数
	int ByteSize() const { return ToPB().ByteSize();}
	//Protobuffer序列化到缓冲区
	bool SerializeToArray( void* data, int size ) const
	{
		return ToPB().SerializeToArray(data,size);
	}
	//Protobuffer序列化到字符串
	string SerializeAsString() const
	{
		return ToPB().SerializeAsString();
	}
	//Protobuffer从字符串进行反序列化
	bool ParseFromString(const string& v)
	{
		return ParseFromArray(v.data(),v.size());
	}
	//Protobuffer从缓冲区进行反序列化
	bool ParseFromArray(const void* data, int size)
	{
		HumanRpcFuncNoticeChangeReply pb;
		if(!pb.ParseFromArray(data,size)){return false;}
		Init(pb);
		return true;
	}

	string HtmlDescHeader()
	{
		string htmlBuff = "<div style=\"padding-left:30px\">\r\n";

		
		htmlBuff += "</div>\r\n";
		return htmlBuff;
	}

	string ToHtml()
	{
		string htmlBuff = "<div style=\"padding-left:30px\">\r\n";
		TStr tmpLine;

		
		htmlBuff += "</div>\r\n";
		return htmlBuff;
	}


private:
	//从Protobuffer类型初始化
	void Init(const HumanRpcFuncNoticeChangeReply& v)
	{
		m_Result = v.result();

	}

private:
	//返回结果
	INT32 m_Result;
public:
	void SetResult( INT32 v)
	{
		m_Result=v;
	}
	INT32 GetResult()
	{
		return m_Result;
	}
	INT32 GetResult() const
	{
		return m_Result;
	}

};
//客户端属性双向通知通知封装类
class HumanRpcClientAttributesNotifyWraper : public DataWraperInterface 
{
public:
	//构造函数
	HumanRpcClientAttributesNotifyWraper()
	{
		
		m_ObjId = -1;
		m_IsTouchJoyStick = false;
		m_IsHold = false;

	}
	//赋值构造函数
	HumanRpcClientAttributesNotifyWraper(const HumanRpcClientAttributesNotify& v){ Init(v); }
	//等号重载函数
	void operator = (const HumanRpcClientAttributesNotify& v){ Init(v); }
 	//转化成Protobuffer类型函数
	HumanRpcClientAttributesNotify ToPB() const
	{
		HumanRpcClientAttributesNotify v;
		v.set_objid( m_ObjId );
		v.set_istouchjoystick( m_IsTouchJoyStick );
		v.set_ishold( m_IsHold );

		return v;
	}
	//获取Protobuffer序列化后大小函数
	int ByteSize() const { return ToPB().ByteSize();}
	//Protobuffer序列化到缓冲区
	bool SerializeToArray( void* data, int size ) const
	{
		return ToPB().SerializeToArray(data,size);
	}
	//Protobuffer序列化到字符串
	string SerializeAsString() const
	{
		return ToPB().SerializeAsString();
	}
	//Protobuffer从字符串进行反序列化
	bool ParseFromString(const string& v)
	{
		return ParseFromArray(v.data(),v.size());
	}
	//Protobuffer从缓冲区进行反序列化
	bool ParseFromArray(const void* data, int size)
	{
		HumanRpcClientAttributesNotify pb;
		if(!pb.ParseFromArray(data,size)){return false;}
		Init(pb);
		return true;
	}

	string HtmlDescHeader()
	{
		string htmlBuff = "<div style=\"padding-left:30px\">\r\n";

		
		htmlBuff += "</div>\r\n";
		return htmlBuff;
	}

	string ToHtml()
	{
		string htmlBuff = "<div style=\"padding-left:30px\">\r\n";
		TStr tmpLine;

		
		htmlBuff += "</div>\r\n";
		return htmlBuff;
	}


private:
	//从Protobuffer类型初始化
	void Init(const HumanRpcClientAttributesNotify& v)
	{
		m_ObjId = v.objid();
		m_IsTouchJoyStick = v.istouchjoystick();
		m_IsHold = v.ishold();

	}

private:
	//目标ID
	INT32 m_ObjId;
public:
	void SetObjId( INT32 v)
	{
		m_ObjId=v;
	}
	INT32 GetObjId()
	{
		return m_ObjId;
	}
	INT32 GetObjId() const
	{
		return m_ObjId;
	}
private:
	//摇杆
	bool m_IsTouchJoyStick;
public:
	void SetIsTouchJoyStick( bool v)
	{
		m_IsTouchJoyStick=v;
	}
	bool GetIsTouchJoyStick()
	{
		return m_IsTouchJoyStick;
	}
	bool GetIsTouchJoyStick() const
	{
		return m_IsTouchJoyStick;
	}
private:
	//hold
	bool m_IsHold;
public:
	void SetIsHold( bool v)
	{
		m_IsHold=v;
	}
	bool GetIsHold()
	{
		return m_IsHold;
	}
	bool GetIsHold() const
	{
		return m_IsHold;
	}

};
//玩家功能预告回应封装类
class HumanRpcFuncNoticeReplyWraper : public DataWraperInterface 
{
public:
	//构造函数
	HumanRpcFuncNoticeReplyWraper()
	{
		
		m_Result = -1;
		m_FuncIndex = -1;

	}
	//赋值构造函数
	HumanRpcFuncNoticeReplyWraper(const HumanRpcFuncNoticeReply& v){ Init(v); }
	//等号重载函数
	void operator = (const HumanRpcFuncNoticeReply& v){ Init(v); }
 	//转化成Protobuffer类型函数
	HumanRpcFuncNoticeReply ToPB() const
	{
		HumanRpcFuncNoticeReply v;
		v.set_result( m_Result );
		v.set_funcindex( m_FuncIndex );

		return v;
	}
	//获取Protobuffer序列化后大小函数
	int ByteSize() const { return ToPB().ByteSize();}
	//Protobuffer序列化到缓冲区
	bool SerializeToArray( void* data, int size ) const
	{
		return ToPB().SerializeToArray(data,size);
	}
	//Protobuffer序列化到字符串
	string SerializeAsString() const
	{
		return ToPB().SerializeAsString();
	}
	//Protobuffer从字符串进行反序列化
	bool ParseFromString(const string& v)
	{
		return ParseFromArray(v.data(),v.size());
	}
	//Protobuffer从缓冲区进行反序列化
	bool ParseFromArray(const void* data, int size)
	{
		HumanRpcFuncNoticeReply pb;
		if(!pb.ParseFromArray(data,size)){return false;}
		Init(pb);
		return true;
	}

	string HtmlDescHeader()
	{
		string htmlBuff = "<div style=\"padding-left:30px\">\r\n";

		
		htmlBuff += "</div>\r\n";
		return htmlBuff;
	}

	string ToHtml()
	{
		string htmlBuff = "<div style=\"padding-left:30px\">\r\n";
		TStr tmpLine;

		
		htmlBuff += "</div>\r\n";
		return htmlBuff;
	}


private:
	//从Protobuffer类型初始化
	void Init(const HumanRpcFuncNoticeReply& v)
	{
		m_Result = v.result();
		m_FuncIndex = v.funcindex();

	}

private:
	//返回结果
	INT32 m_Result;
public:
	void SetResult( INT32 v)
	{
		m_Result=v;
	}
	INT32 GetResult()
	{
		return m_Result;
	}
	INT32 GetResult() const
	{
		return m_Result;
	}
private:
	//功能索引
	INT32 m_FuncIndex;
public:
	void SetFuncIndex( INT32 v)
	{
		m_FuncIndex=v;
	}
	INT32 GetFuncIndex()
	{
		return m_FuncIndex;
	}
	INT32 GetFuncIndex() const
	{
		return m_FuncIndex;
	}

};
//玩家功能预告请求封装类
class HumanRpcFuncNoticeChangeAskWraper : public DataWraperInterface 
{
public:
	//构造函数
	HumanRpcFuncNoticeChangeAskWraper()
	{
		

	}
	//赋值构造函数
	HumanRpcFuncNoticeChangeAskWraper(const HumanRpcFuncNoticeChangeAsk& v){ Init(v); }
	//等号重载函数
	void operator = (const HumanRpcFuncNoticeChangeAsk& v){ Init(v); }
 	//转化成Protobuffer类型函数
	HumanRpcFuncNoticeChangeAsk ToPB() const
	{
		HumanRpcFuncNoticeChangeAsk v;

		return v;
	}
	//获取Protobuffer序列化后大小函数
	int ByteSize() const { return ToPB().ByteSize();}
	//Protobuffer序列化到缓冲区
	bool SerializeToArray( void* data, int size ) const
	{
		return ToPB().SerializeToArray(data,size);
	}
	//Protobuffer序列化到字符串
	string SerializeAsString() const
	{
		return ToPB().SerializeAsString();
	}
	//Protobuffer从字符串进行反序列化
	bool ParseFromString(const string& v)
	{
		return ParseFromArray(v.data(),v.size());
	}
	//Protobuffer从缓冲区进行反序列化
	bool ParseFromArray(const void* data, int size)
	{
		HumanRpcFuncNoticeChangeAsk pb;
		if(!pb.ParseFromArray(data,size)){return false;}
		Init(pb);
		return true;
	}

	string HtmlDescHeader()
	{
		string htmlBuff = "<div style=\"padding-left:30px\">\r\n";

		
		htmlBuff += "</div>\r\n";
		return htmlBuff;
	}

	string ToHtml()
	{
		string htmlBuff = "<div style=\"padding-left:30px\">\r\n";
		TStr tmpLine;

		
		htmlBuff += "</div>\r\n";
		return htmlBuff;
	}


private:
	//从Protobuffer类型初始化
	void Init(const HumanRpcFuncNoticeChangeAsk& v)
	{

	}


};
//MovePos请求封装类
class HumanRpcMovePosAskWraper : public DataWraperInterface 
{
public:
	//构造函数
	HumanRpcMovePosAskWraper()
	{
		
		m_Dir = -1;
		m_ObjId = -1;
		m_IsAllowChangeRunAnimation = true;

	}
	//赋值构造函数
	HumanRpcMovePosAskWraper(const HumanRpcMovePosAsk& v){ Init(v); }
	//等号重载函数
	void operator = (const HumanRpcMovePosAsk& v){ Init(v); }
 	//转化成Protobuffer类型函数
	HumanRpcMovePosAsk ToPB() const
	{
		HumanRpcMovePosAsk v;
		v.mutable_poslist()->Reserve(m_PosList.size());
		for (int i=0; i<(int)m_PosList.size(); i++)
		{
			*v.add_poslist() = m_PosList[i].ToPB();
		}
		v.set_dir( m_Dir );
		v.set_objid( m_ObjId );
		v.set_isallowchangerunanimation( m_IsAllowChangeRunAnimation );

		return v;
	}
	//获取Protobuffer序列化后大小函数
	int ByteSize() const { return ToPB().ByteSize();}
	//Protobuffer序列化到缓冲区
	bool SerializeToArray( void* data, int size ) const
	{
		return ToPB().SerializeToArray(data,size);
	}
	//Protobuffer序列化到字符串
	string SerializeAsString() const
	{
		return ToPB().SerializeAsString();
	}
	//Protobuffer从字符串进行反序列化
	bool ParseFromString(const string& v)
	{
		return ParseFromArray(v.data(),v.size());
	}
	//Protobuffer从缓冲区进行反序列化
	bool ParseFromArray(const void* data, int size)
	{
		HumanRpcMovePosAsk pb;
		if(!pb.ParseFromArray(data,size)){return false;}
		Init(pb);
		return true;
	}

	string HtmlDescHeader()
	{
		string htmlBuff = "<div style=\"padding-left:30px\">\r\n";

		
		htmlBuff += "</div>\r\n";
		return htmlBuff;
	}

	string ToHtml()
	{
		string htmlBuff = "<div style=\"padding-left:30px\">\r\n";
		TStr tmpLine;

		
		htmlBuff += "</div>\r\n";
		return htmlBuff;
	}


private:
	//从Protobuffer类型初始化
	void Init(const HumanRpcMovePosAsk& v)
	{
		m_PosList.clear();
		m_PosList.reserve(v.poslist_size());
		for( int i=0; i<v.poslist_size(); i++)
			m_PosList.push_back(v.poslist(i));
		m_Dir = v.dir();
		m_ObjId = v.objid();
		m_IsAllowChangeRunAnimation = v.isallowchangerunanimation();

	}

private:
	//要移动的位置
	vector<Vector3IntWraper> m_PosList;
public:
	int SizePosList()
	{
		return m_PosList.size();
	}
	const vector<Vector3IntWraper>& GetPosList() const
	{
		return m_PosList;
	}
	Vector3IntWraper GetPosList(int Index) const
	{
		if(Index<0 || Index>=(int)m_PosList.size())
		{
			assert(false);
			return Vector3IntWraper();
		}
		return m_PosList[Index];
	}
	void SetPosList( const vector<Vector3IntWraper>& v )
	{
		m_PosList=v;
	}
	void ClearPosList( )
	{
		m_PosList.clear();
	}
	void SetPosList( int Index, const Vector3IntWraper& v )
	{
		if(Index<0 || Index>=(int)m_PosList.size())
		{
			assert(false);
			return;
		}
		m_PosList[Index] = v;
	}
	void AddPosList( const Vector3IntWraper& v )
	{
		m_PosList.push_back(v);
	}
private:
	//Dir
	float m_Dir;
public:
	void SetDir( float v)
	{
		m_Dir=v;
	}
	float GetDir()
	{
		return m_Dir;
	}
	float GetDir() const
	{
		return m_Dir;
	}
private:
	//目标ID
	INT32 m_ObjId;
public:
	void SetObjId( INT32 v)
	{
		m_ObjId=v;
	}
	INT32 GetObjId()
	{
		return m_ObjId;
	}
	INT32 GetObjId() const
	{
		return m_ObjId;
	}
private:
	//是否允许切换Run动画
	bool m_IsAllowChangeRunAnimation;
public:
	void SetIsAllowChangeRunAnimation( bool v)
	{
		m_IsAllowChangeRunAnimation=v;
	}
	bool GetIsAllowChangeRunAnimation()
	{
		return m_IsAllowChangeRunAnimation;
	}
	bool GetIsAllowChangeRunAnimation() const
	{
		return m_IsAllowChangeRunAnimation;
	}

};
//客户端停止移动请求封装类
class HumanRpcStopMoveAskWraper : public DataWraperInterface 
{
public:
	//构造函数
	HumanRpcStopMoveAskWraper()
	{
		
		m_Dir = -1;
		m_X = -1;
		m_Z = -1;
		m_ObjId = -1;

	}
	//赋值构造函数
	HumanRpcStopMoveAskWraper(const HumanRpcStopMoveAsk& v){ Init(v); }
	//等号重载函数
	void operator = (const HumanRpcStopMoveAsk& v){ Init(v); }
 	//转化成Protobuffer类型函数
	HumanRpcStopMoveAsk ToPB() const
	{
		HumanRpcStopMoveAsk v;
		v.set_dir( m_Dir );
		v.set_x( m_X );
		v.set_z( m_Z );
		v.set_objid( m_ObjId );

		return v;
	}
	//获取Protobuffer序列化后大小函数
	int ByteSize() const { return ToPB().ByteSize();}
	//Protobuffer序列化到缓冲区
	bool SerializeToArray( void* data, int size ) const
	{
		return ToPB().SerializeToArray(data,size);
	}
	//Protobuffer序列化到字符串
	string SerializeAsString() const
	{
		return ToPB().SerializeAsString();
	}
	//Protobuffer从字符串进行反序列化
	bool ParseFromString(const string& v)
	{
		return ParseFromArray(v.data(),v.size());
	}
	//Protobuffer从缓冲区进行反序列化
	bool ParseFromArray(const void* data, int size)
	{
		HumanRpcStopMoveAsk pb;
		if(!pb.ParseFromArray(data,size)){return false;}
		Init(pb);
		return true;
	}

	string HtmlDescHeader()
	{
		string htmlBuff = "<div style=\"padding-left:30px\">\r\n";

		
		htmlBuff += "</div>\r\n";
		return htmlBuff;
	}

	string ToHtml()
	{
		string htmlBuff = "<div style=\"padding-left:30px\">\r\n";
		TStr tmpLine;

		
		htmlBuff += "</div>\r\n";
		return htmlBuff;
	}


private:
	//从Protobuffer类型初始化
	void Init(const HumanRpcStopMoveAsk& v)
	{
		m_Dir = v.dir();
		m_X = v.x();
		m_Z = v.z();
		m_ObjId = v.objid();

	}

private:
	//移动方向
	float m_Dir;
public:
	void SetDir( float v)
	{
		m_Dir=v;
	}
	float GetDir()
	{
		return m_Dir;
	}
	float GetDir() const
	{
		return m_Dir;
	}
private:
	//CurPosX
	INT32 m_X;
public:
	void SetX( INT32 v)
	{
		m_X=v;
	}
	INT32 GetX()
	{
		return m_X;
	}
	INT32 GetX() const
	{
		return m_X;
	}
private:
	//CurPosZ
	INT32 m_Z;
public:
	void SetZ( INT32 v)
	{
		m_Z=v;
	}
	INT32 GetZ()
	{
		return m_Z;
	}
	INT32 GetZ() const
	{
		return m_Z;
	}
private:
	//目标ID
	INT32 m_ObjId;
public:
	void SetObjId( INT32 v)
	{
		m_ObjId=v;
	}
	INT32 GetObjId()
	{
		return m_ObjId;
	}
	INT32 GetObjId() const
	{
		return m_ObjId;
	}

};
//客户端停止移动回应封装类
class HumanRpcStopMoveReplyWraper : public DataWraperInterface 
{
public:
	//构造函数
	HumanRpcStopMoveReplyWraper()
	{
		
		m_Result = -9999;
		m_Pos = Vector3IntWraper();
		m_Dir = -1;
		m_ObjId = -1;

	}
	//赋值构造函数
	HumanRpcStopMoveReplyWraper(const HumanRpcStopMoveReply& v){ Init(v); }
	//等号重载函数
	void operator = (const HumanRpcStopMoveReply& v){ Init(v); }
 	//转化成Protobuffer类型函数
	HumanRpcStopMoveReply ToPB() const
	{
		HumanRpcStopMoveReply v;
		v.set_result( m_Result );
		*v.mutable_pos()= m_Pos.ToPB();
		v.set_dir( m_Dir );
		v.set_objid( m_ObjId );

		return v;
	}
	//获取Protobuffer序列化后大小函数
	int ByteSize() const { return ToPB().ByteSize();}
	//Protobuffer序列化到缓冲区
	bool SerializeToArray( void* data, int size ) const
	{
		return ToPB().SerializeToArray(data,size);
	}
	//Protobuffer序列化到字符串
	string SerializeAsString() const
	{
		return ToPB().SerializeAsString();
	}
	//Protobuffer从字符串进行反序列化
	bool ParseFromString(const string& v)
	{
		return ParseFromArray(v.data(),v.size());
	}
	//Protobuffer从缓冲区进行反序列化
	bool ParseFromArray(const void* data, int size)
	{
		HumanRpcStopMoveReply pb;
		if(!pb.ParseFromArray(data,size)){return false;}
		Init(pb);
		return true;
	}

	string HtmlDescHeader()
	{
		string htmlBuff = "<div style=\"padding-left:30px\">\r\n";

		
		htmlBuff += "</div>\r\n";
		return htmlBuff;
	}

	string ToHtml()
	{
		string htmlBuff = "<div style=\"padding-left:30px\">\r\n";
		TStr tmpLine;

		
		htmlBuff += "</div>\r\n";
		return htmlBuff;
	}


private:
	//从Protobuffer类型初始化
	void Init(const HumanRpcStopMoveReply& v)
	{
		m_Result = v.result();
		m_Pos = v.pos();
		m_Dir = v.dir();
		m_ObjId = v.objid();

	}

private:
	//返回结果
	INT32 m_Result;
public:
	void SetResult( INT32 v)
	{
		m_Result=v;
	}
	INT32 GetResult()
	{
		return m_Result;
	}
	INT32 GetResult() const
	{
		return m_Result;
	}
private:
	//当前位置
	Vector3IntWraper m_Pos;
public:
	void SetPos( const Vector3IntWraper& v)
	{
		m_Pos=v;
	}
	Vector3IntWraper GetPos()
	{
		return m_Pos;
	}
	Vector3IntWraper GetPos() const
	{
		return m_Pos;
	}
private:
	//移动方向
	float m_Dir;
public:
	void SetDir( float v)
	{
		m_Dir=v;
	}
	float GetDir()
	{
		return m_Dir;
	}
	float GetDir() const
	{
		return m_Dir;
	}
private:
	//目标ID
	INT32 m_ObjId;
public:
	void SetObjId( INT32 v)
	{
		m_ObjId=v;
	}
	INT32 GetObjId()
	{
		return m_ObjId;
	}
	INT32 GetObjId() const
	{
		return m_ObjId;
	}

};
//human move请求封装类
class HumanRpcMoveAskWraper : public DataWraperInterface 
{
public:
	//构造函数
	HumanRpcMoveAskWraper()
	{
		
		m_Dir = -1;
		m_X = -1;
		m_Z = -1;
		m_ObjId = -1;

	}
	//赋值构造函数
	HumanRpcMoveAskWraper(const HumanRpcMoveAsk& v){ Init(v); }
	//等号重载函数
	void operator = (const HumanRpcMoveAsk& v){ Init(v); }
 	//转化成Protobuffer类型函数
	HumanRpcMoveAsk ToPB() const
	{
		HumanRpcMoveAsk v;
		v.set_dir( m_Dir );
		v.set_x( m_X );
		v.set_z( m_Z );
		v.set_objid( m_ObjId );

		return v;
	}
	//获取Protobuffer序列化后大小函数
	int ByteSize() const { return ToPB().ByteSize();}
	//Protobuffer序列化到缓冲区
	bool SerializeToArray( void* data, int size ) const
	{
		return ToPB().SerializeToArray(data,size);
	}
	//Protobuffer序列化到字符串
	string SerializeAsString() const
	{
		return ToPB().SerializeAsString();
	}
	//Protobuffer从字符串进行反序列化
	bool ParseFromString(const string& v)
	{
		return ParseFromArray(v.data(),v.size());
	}
	//Protobuffer从缓冲区进行反序列化
	bool ParseFromArray(const void* data, int size)
	{
		HumanRpcMoveAsk pb;
		if(!pb.ParseFromArray(data,size)){return false;}
		Init(pb);
		return true;
	}

	string HtmlDescHeader()
	{
		string htmlBuff = "<div style=\"padding-left:30px\">\r\n";

		
		htmlBuff += "</div>\r\n";
		return htmlBuff;
	}

	string ToHtml()
	{
		string htmlBuff = "<div style=\"padding-left:30px\">\r\n";
		TStr tmpLine;

		
		htmlBuff += "</div>\r\n";
		return htmlBuff;
	}


private:
	//从Protobuffer类型初始化
	void Init(const HumanRpcMoveAsk& v)
	{
		m_Dir = v.dir();
		m_X = v.x();
		m_Z = v.z();
		m_ObjId = v.objid();

	}

private:
	//移动方向
	float m_Dir;
public:
	void SetDir( float v)
	{
		m_Dir=v;
	}
	float GetDir()
	{
		return m_Dir;
	}
	float GetDir() const
	{
		return m_Dir;
	}
private:
	//CurPosX
	float m_X;
public:
	void SetX( float v)
	{
		m_X=v;
	}
	float GetX()
	{
		return m_X;
	}
	float GetX() const
	{
		return m_X;
	}
private:
	//CurPosZ
	float m_Z;
public:
	void SetZ( float v)
	{
		m_Z=v;
	}
	float GetZ()
	{
		return m_Z;
	}
	float GetZ() const
	{
		return m_Z;
	}
private:
	//目标ID
	INT32 m_ObjId;
public:
	void SetObjId( INT32 v)
	{
		m_ObjId=v;
	}
	INT32 GetObjId()
	{
		return m_ObjId;
	}
	INT32 GetObjId() const
	{
		return m_ObjId;
	}

};
//human move回应封装类
class HumanRpcMoveReplyWraper : public DataWraperInterface 
{
public:
	//构造函数
	HumanRpcMoveReplyWraper()
	{
		
		m_Result = -9999;
		m_Pos = Vector3Wraper();
		m_Dir = -1;
		m_ObjId = -1;

	}
	//赋值构造函数
	HumanRpcMoveReplyWraper(const HumanRpcMoveReply& v){ Init(v); }
	//等号重载函数
	void operator = (const HumanRpcMoveReply& v){ Init(v); }
 	//转化成Protobuffer类型函数
	HumanRpcMoveReply ToPB() const
	{
		HumanRpcMoveReply v;
		v.set_result( m_Result );
		*v.mutable_pos()= m_Pos.ToPB();
		v.set_dir( m_Dir );
		v.set_objid( m_ObjId );

		return v;
	}
	//获取Protobuffer序列化后大小函数
	int ByteSize() const { return ToPB().ByteSize();}
	//Protobuffer序列化到缓冲区
	bool SerializeToArray( void* data, int size ) const
	{
		return ToPB().SerializeToArray(data,size);
	}
	//Protobuffer序列化到字符串
	string SerializeAsString() const
	{
		return ToPB().SerializeAsString();
	}
	//Protobuffer从字符串进行反序列化
	bool ParseFromString(const string& v)
	{
		return ParseFromArray(v.data(),v.size());
	}
	//Protobuffer从缓冲区进行反序列化
	bool ParseFromArray(const void* data, int size)
	{
		HumanRpcMoveReply pb;
		if(!pb.ParseFromArray(data,size)){return false;}
		Init(pb);
		return true;
	}

	string HtmlDescHeader()
	{
		string htmlBuff = "<div style=\"padding-left:30px\">\r\n";

		
		htmlBuff += "</div>\r\n";
		return htmlBuff;
	}

	string ToHtml()
	{
		string htmlBuff = "<div style=\"padding-left:30px\">\r\n";
		TStr tmpLine;

		
		htmlBuff += "</div>\r\n";
		return htmlBuff;
	}


private:
	//从Protobuffer类型初始化
	void Init(const HumanRpcMoveReply& v)
	{
		m_Result = v.result();
		m_Pos = v.pos();
		m_Dir = v.dir();
		m_ObjId = v.objid();

	}

private:
	//返回结果
	INT32 m_Result;
public:
	void SetResult( INT32 v)
	{
		m_Result=v;
	}
	INT32 GetResult()
	{
		return m_Result;
	}
	INT32 GetResult() const
	{
		return m_Result;
	}
private:
	//当前位置
	Vector3Wraper m_Pos;
public:
	void SetPos( const Vector3Wraper& v)
	{
		m_Pos=v;
	}
	Vector3Wraper GetPos()
	{
		return m_Pos;
	}
	Vector3Wraper GetPos() const
	{
		return m_Pos;
	}
private:
	//移动方向
	float m_Dir;
public:
	void SetDir( float v)
	{
		m_Dir=v;
	}
	float GetDir()
	{
		return m_Dir;
	}
	float GetDir() const
	{
		return m_Dir;
	}
private:
	//目标ID
	INT32 m_ObjId;
public:
	void SetObjId( INT32 v)
	{
		m_ObjId=v;
	}
	INT32 GetObjId()
	{
		return m_ObjId;
	}
	INT32 GetObjId() const
	{
		return m_ObjId;
	}

};
//Respawn回应封装类
class HumanRpcRespawnReplyWraper : public DataWraperInterface 
{
public:
	//构造函数
	HumanRpcRespawnReplyWraper()
	{
		
		m_Result = -9999;
		m_ReviveType = -1;

	}
	//赋值构造函数
	HumanRpcRespawnReplyWraper(const HumanRpcRespawnReply& v){ Init(v); }
	//等号重载函数
	void operator = (const HumanRpcRespawnReply& v){ Init(v); }
 	//转化成Protobuffer类型函数
	HumanRpcRespawnReply ToPB() const
	{
		HumanRpcRespawnReply v;
		v.set_result( m_Result );
		v.set_revivetype( m_ReviveType );

		return v;
	}
	//获取Protobuffer序列化后大小函数
	int ByteSize() const { return ToPB().ByteSize();}
	//Protobuffer序列化到缓冲区
	bool SerializeToArray( void* data, int size ) const
	{
		return ToPB().SerializeToArray(data,size);
	}
	//Protobuffer序列化到字符串
	string SerializeAsString() const
	{
		return ToPB().SerializeAsString();
	}
	//Protobuffer从字符串进行反序列化
	bool ParseFromString(const string& v)
	{
		return ParseFromArray(v.data(),v.size());
	}
	//Protobuffer从缓冲区进行反序列化
	bool ParseFromArray(const void* data, int size)
	{
		HumanRpcRespawnReply pb;
		if(!pb.ParseFromArray(data,size)){return false;}
		Init(pb);
		return true;
	}

	string HtmlDescHeader()
	{
		string htmlBuff = "<div style=\"padding-left:30px\">\r\n";

		
		htmlBuff += "</div>\r\n";
		return htmlBuff;
	}

	string ToHtml()
	{
		string htmlBuff = "<div style=\"padding-left:30px\">\r\n";
		TStr tmpLine;

		
		htmlBuff += "</div>\r\n";
		return htmlBuff;
	}


private:
	//从Protobuffer类型初始化
	void Init(const HumanRpcRespawnReply& v)
	{
		m_Result = v.result();
		m_ReviveType = v.revivetype();

	}

private:
	//返回结果
	INT32 m_Result;
public:
	void SetResult( INT32 v)
	{
		m_Result=v;
	}
	INT32 GetResult()
	{
		return m_Result;
	}
	INT32 GetResult() const
	{
		return m_Result;
	}
private:
	//复活类型
	INT32 m_ReviveType;
public:
	void SetReviveType( INT32 v)
	{
		m_ReviveType=v;
	}
	INT32 GetReviveType()
	{
		return m_ReviveType;
	}
	INT32 GetReviveType() const
	{
		return m_ReviveType;
	}

};
//复活其他玩家通知通知封装类
class HumanRpcRespawnOtherNotifyWraper : public DataWraperInterface 
{
public:
	//构造函数
	HumanRpcRespawnOtherNotifyWraper()
	{
		
		m_ObjId = -1;

	}
	//赋值构造函数
	HumanRpcRespawnOtherNotifyWraper(const HumanRpcRespawnOtherNotify& v){ Init(v); }
	//等号重载函数
	void operator = (const HumanRpcRespawnOtherNotify& v){ Init(v); }
 	//转化成Protobuffer类型函数
	HumanRpcRespawnOtherNotify ToPB() const
	{
		HumanRpcRespawnOtherNotify v;
		v.set_objid( m_ObjId );

		return v;
	}
	//获取Protobuffer序列化后大小函数
	int ByteSize() const { return ToPB().ByteSize();}
	//Protobuffer序列化到缓冲区
	bool SerializeToArray( void* data, int size ) const
	{
		return ToPB().SerializeToArray(data,size);
	}
	//Protobuffer序列化到字符串
	string SerializeAsString() const
	{
		return ToPB().SerializeAsString();
	}
	//Protobuffer从字符串进行反序列化
	bool ParseFromString(const string& v)
	{
		return ParseFromArray(v.data(),v.size());
	}
	//Protobuffer从缓冲区进行反序列化
	bool ParseFromArray(const void* data, int size)
	{
		HumanRpcRespawnOtherNotify pb;
		if(!pb.ParseFromArray(data,size)){return false;}
		Init(pb);
		return true;
	}

	string HtmlDescHeader()
	{
		string htmlBuff = "<div style=\"padding-left:30px\">\r\n";

		
		htmlBuff += "</div>\r\n";
		return htmlBuff;
	}

	string ToHtml()
	{
		string htmlBuff = "<div style=\"padding-left:30px\">\r\n";
		TStr tmpLine;

		
		htmlBuff += "</div>\r\n";
		return htmlBuff;
	}


private:
	//从Protobuffer类型初始化
	void Init(const HumanRpcRespawnOtherNotify& v)
	{
		m_ObjId = v.objid();

	}

private:
	//ObjId
	INT32 m_ObjId;
public:
	void SetObjId( INT32 v)
	{
		m_ObjId=v;
	}
	INT32 GetObjId()
	{
		return m_ObjId;
	}
	INT32 GetObjId() const
	{
		return m_ObjId;
	}

};
//移动检测通知封装类
class HumanRpcMoveCheckNotifyWraper : public DataWraperInterface 
{
public:
	//构造函数
	HumanRpcMoveCheckNotifyWraper()
	{
		
		m_ObjId = -1;
		m_Dir = -1;
		m_X = -1;
		m_Y = -1;

	}
	//赋值构造函数
	HumanRpcMoveCheckNotifyWraper(const HumanRpcMoveCheckNotify& v){ Init(v); }
	//等号重载函数
	void operator = (const HumanRpcMoveCheckNotify& v){ Init(v); }
 	//转化成Protobuffer类型函数
	HumanRpcMoveCheckNotify ToPB() const
	{
		HumanRpcMoveCheckNotify v;
		v.set_objid( m_ObjId );
		v.set_dir( m_Dir );
		v.set_x( m_X );
		v.set_y( m_Y );

		return v;
	}
	//获取Protobuffer序列化后大小函数
	int ByteSize() const { return ToPB().ByteSize();}
	//Protobuffer序列化到缓冲区
	bool SerializeToArray( void* data, int size ) const
	{
		return ToPB().SerializeToArray(data,size);
	}
	//Protobuffer序列化到字符串
	string SerializeAsString() const
	{
		return ToPB().SerializeAsString();
	}
	//Protobuffer从字符串进行反序列化
	bool ParseFromString(const string& v)
	{
		return ParseFromArray(v.data(),v.size());
	}
	//Protobuffer从缓冲区进行反序列化
	bool ParseFromArray(const void* data, int size)
	{
		HumanRpcMoveCheckNotify pb;
		if(!pb.ParseFromArray(data,size)){return false;}
		Init(pb);
		return true;
	}

	string HtmlDescHeader()
	{
		string htmlBuff = "<div style=\"padding-left:30px\">\r\n";

		
		htmlBuff += "</div>\r\n";
		return htmlBuff;
	}

	string ToHtml()
	{
		string htmlBuff = "<div style=\"padding-left:30px\">\r\n";
		TStr tmpLine;

		
		htmlBuff += "</div>\r\n";
		return htmlBuff;
	}


private:
	//从Protobuffer类型初始化
	void Init(const HumanRpcMoveCheckNotify& v)
	{
		m_ObjId = v.objid();
		m_Dir = v.dir();
		m_X = v.x();
		m_Y = v.y();

	}

private:
	//角色ID
	INT32 m_ObjId;
public:
	void SetObjId( INT32 v)
	{
		m_ObjId=v;
	}
	INT32 GetObjId()
	{
		return m_ObjId;
	}
	INT32 GetObjId() const
	{
		return m_ObjId;
	}
private:
	//方向
	float m_Dir;
public:
	void SetDir( float v)
	{
		m_Dir=v;
	}
	float GetDir()
	{
		return m_Dir;
	}
	float GetDir() const
	{
		return m_Dir;
	}
private:
	//x位置
	float m_X;
public:
	void SetX( float v)
	{
		m_X=v;
	}
	float GetX()
	{
		return m_X;
	}
	float GetX() const
	{
		return m_X;
	}
private:
	//y位置
	float m_Y;
public:
	void SetY( float v)
	{
		m_Y=v;
	}
	float GetY()
	{
		return m_Y;
	}
	float GetY() const
	{
		return m_Y;
	}

};
//Respawn请求封装类
class HumanRpcRespawnAskWraper : public DataWraperInterface 
{
public:
	//构造函数
	HumanRpcRespawnAskWraper()
	{
		
		m_ReviveType = -1;

	}
	//赋值构造函数
	HumanRpcRespawnAskWraper(const HumanRpcRespawnAsk& v){ Init(v); }
	//等号重载函数
	void operator = (const HumanRpcRespawnAsk& v){ Init(v); }
 	//转化成Protobuffer类型函数
	HumanRpcRespawnAsk ToPB() const
	{
		HumanRpcRespawnAsk v;
		v.set_revivetype( m_ReviveType );

		return v;
	}
	//获取Protobuffer序列化后大小函数
	int ByteSize() const { return ToPB().ByteSize();}
	//Protobuffer序列化到缓冲区
	bool SerializeToArray( void* data, int size ) const
	{
		return ToPB().SerializeToArray(data,size);
	}
	//Protobuffer序列化到字符串
	string SerializeAsString() const
	{
		return ToPB().SerializeAsString();
	}
	//Protobuffer从字符串进行反序列化
	bool ParseFromString(const string& v)
	{
		return ParseFromArray(v.data(),v.size());
	}
	//Protobuffer从缓冲区进行反序列化
	bool ParseFromArray(const void* data, int size)
	{
		HumanRpcRespawnAsk pb;
		if(!pb.ParseFromArray(data,size)){return false;}
		Init(pb);
		return true;
	}

	string HtmlDescHeader()
	{
		string htmlBuff = "<div style=\"padding-left:30px\">\r\n";

		
		htmlBuff += "</div>\r\n";
		return htmlBuff;
	}

	string ToHtml()
	{
		string htmlBuff = "<div style=\"padding-left:30px\">\r\n";
		TStr tmpLine;

		
		htmlBuff += "</div>\r\n";
		return htmlBuff;
	}


private:
	//从Protobuffer类型初始化
	void Init(const HumanRpcRespawnAsk& v)
	{
		m_ReviveType = v.revivetype();

	}

private:
	//复活类型
	INT32 m_ReviveType;
public:
	void SetReviveType( INT32 v)
	{
		m_ReviveType=v;
	}
	INT32 GetReviveType()
	{
		return m_ReviveType;
	}
	INT32 GetReviveType() const
	{
		return m_ReviveType;
	}

};

template<typename T> struct MessageIdT;
template<> struct MessageIdT<HumanRpcMoveCheckNotifyWraper>{ enum{ID=RPC_CODE_HUMAN_MOVECHECK_NOTIFY};};
template<> struct MessageIdT<HumanRpcRespawnOtherNotifyWraper>{ enum{ID=RPC_CODE_HUMAN_RESPAWNOTHER_NOTIFY};};
template<> struct MessageIdT<HumanRpcRoleDieNotifyWraper>{ enum{ID=RPC_CODE_HUMAN_ROLEDIE_NOTIFY};};
template<> struct MessageIdT<HumanRpcChangeAnimationStateNotifyWraper>{ enum{ID=RPC_CODE_HUMAN_CHANGEANIMATIONSTATE_NOTIFY};};
template<> struct MessageIdT<HumanRpcClientAttributesNotifyWraper>{ enum{ID=RPC_CODE_HUMAN_CLIENTATTRIBUTES_NOTIFY};};


#endif
