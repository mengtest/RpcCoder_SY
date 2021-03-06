﻿/********************************************************************************************
* Copyright (C), 2011-2025, Ambition. Co., Ltd.
* FileName:     TeamDBCache.cpp
* Author:       郭晓波
* Description:  Team数据类
* Version:      1.0
* History:
* <author>  <time>   <version >   <desc>
* 
********************************************************************************************/

#include "TeamDBCache.h"
#include "BASE.h"


IMPLEMENT_INSTANCE(DataTeam);

//Team实现类构造函数
DataTeam::DataTeam()
{
	m_mapDataWraperVersionName[1] = "TeamMemberWraperV1";
	
}

//Team实现类析构函数
DataTeam::~DataTeam()
{

}


//获取模块ID
UINT8 DataTeam::GetModuleId()
{
	return MODULE_ID_TEAM;
}

//获取模块名字
TStr DataTeam::GetModuleName()
{
	return "Team";
}

//获取模块同步(保存)数据版本及类名
map<INT32,TStr> DataTeam::GetDataWraperVersionName()
{

	return m_mapDataWraperVersionName;
}

//模块同步(保存)数据升级函数
bool DataTeam::UpdateModuleData(ModuleDataInterface* pre, ModuleDataInterface* cur )
{
	
	return true;
}
//模块数据保存类型
SavedDataTypeE	DataTeam::GetSavedDataType()
{
	return SAVE_USER_DATA;
}

//是否保存数据到数据库中
bool DataTeam::IsSaveModuleDataToDB()
{

	return true;
}

//增量更新通知
bool DataTeam::OnIncrementUpdate( INT64 key, int syncId, int Index, const char* pBuffer, int dataLen )
{
	TeamMemberWraperV1* pDataWraper = (TeamMemberWraperV1*)GetModuleData(key);
	if( pDataWraper == NULL )
	{
		assert(false);
		return false;
	}
	
	INT64 lValue = 0;
	int   iValue = 0;
	
	switch (syncId)
	{
	case SYNCID_TEAM_ROLEID:
		ReadVarint64FromArray(pBuffer,&lValue);
		pDataWraper->SetRoleId(lValue);
		break;
	case SYNCID_TEAM_SCENEID:
		ReadVarint32FromArray(pBuffer,&iValue);
		pDataWraper->SetSceneId(iValue);
		break;
	case SYNCID_TEAM_LEVEL:
		ReadVarint32FromArray(pBuffer,&iValue);
		pDataWraper->SetLevel(iValue);
		break;
	case SYNCID_TEAM_NAME:
		pDataWraper->SetName(string(pBuffer,dataLen));
		break;
	case SYNCID_TEAM_CONFIGID:
		ReadVarint32FromArray(pBuffer,&iValue);
		pDataWraper->SetConfigId(iValue);
		break;
	case SYNCID_TEAM_HP:
		ReadVarint32FromArray(pBuffer,&iValue);
		pDataWraper->SetHp(iValue);
		break;
	case SYNCID_TEAM_MP:
		ReadVarint32FromArray(pBuffer,&iValue);
		pDataWraper->SetMp(iValue);
		break;
	case SYNCID_TEAM_STATUS:
		ReadVarint32FromArray(pBuffer,&iValue);
		pDataWraper->SetStatus(iValue);
		break;

	default:
		break;
	}
	pDataWraper->OnDataChange();
	lValue ++;
	iValue ++;
	return true;
}
