/********************************************************************************************
* Copyright (C), 2011-2025, AGAN Tech. Co., Ltd.
* FileName:     ModuleTreasureMap.cpp
* Author:       甘业清
* Description:  藏宝图类，包含以下内容
*               ★模块基本信息函数
*               ★初始化结束回调函数
*               ★时间相当回调函数
*               ★用户创建上下线回调函数
*               ★模块数据修改及同步回调函数
* Version:      1.0
* History:
* <author>  <time>   <version >   <desc>
* 
********************************************************************************************/

#include "TreasureMapModule.h"
#include "BASE.h"
#include "MsgIdMgr.h"


IMPLEMENT_INSTANCE(ModuleTreasureMap);

//藏宝图实现类构造函数
ModuleTreasureMap::ModuleTreasureMap()
{

	g_pPacketMgr->registerHandle(	RPC_CODE_TREASUREMAP_TREASUREMAPSYNC_REQUEST, &ModuleTreasureMap::RpcTreasureMapSync);
	g_pPacketMgr->registerPacketFacotry(	RPC_CODE_TREASUREMAP_TREASUREMAPSYNC_REQUEST, new Some_Factory<TreasureMapRpcTreasureMapSyncAsk>());


	
	m_mapSyncDataVersionName[1] = "SyncDataTreasureMapV1";
		
}

//藏宝图实现类析构函数
ModuleTreasureMap::~ModuleTreasureMap()
{

}


//获取模块ID
UINT8 ModuleTreasureMap::GetModuleId()
{
	return MODULE_ID_TREASUREMAP;
}

//获取模块名字
TStr ModuleTreasureMap::GetModuleName()
{
	return "TreasureMap";
}

//获取模块同步(保存)数据版本及类名
map<INT32,TStr> ModuleTreasureMap::GetModuleDataVersionName()
{

	return m_mapSyncDataVersionName;
}

//模块数据保存类型
SavedDataTypeE	ModuleTreasureMap::GetSavedDataType()
{
	return SAVE_ITEM_DATA;
}


//获取初始化顺序
int	ModuleTreasureMap::GetInitializeOrder()
{
	return MODULE_ID_TREASUREMAP;
}

//获取结束退出顺序
int ModuleTreasureMap::GetFinalizeOrder()
{
	return MODULE_ID_TREASUREMAP;
}

//初始化
bool ModuleTreasureMap::Initialize()
{

	

	return true;
}

//结束退出
void ModuleTreasureMap::Finalize()
{

}


//毫秒级Tick回调
void ModuleTreasureMap::OnTick( INT64 currentMiliSecond )
{

}

//秒级Tick回调
void ModuleTreasureMap::OnSecondTick( time_t currentSecond )
{

}

//分钟改变回调
void ModuleTreasureMap::OnMinuteChange( time_t currentSecond)
{

}

//小时改变回调
void ModuleTreasureMap::OnHourChange( time_t currentSecond )
{

}

//天改变回调
void ModuleTreasureMap::OnDayChange( time_t currentSecond )
{

}

//创建用户回调
void ModuleTreasureMap::OnUserCreate( INT64 userId, const TStr& userName )
{

}

//用户上线回调
void ModuleTreasureMap::OnUserOnline( INT64 userId, time_t lastLogoutTime )
{

}

//用户下线回调
void ModuleTreasureMap::OnUserOffline( INT64 userId )
{

}

//是否要同步数据到客户端
bool ModuleTreasureMap::NotSyncToClient( UINT16 usSyncId )
{

	return false;
}

//同步数据修改后回调
void ModuleTreasureMap::NotifySyncValueChanged(INT64 Key,UINT16 usSyncId, int nIndex)
{

}

