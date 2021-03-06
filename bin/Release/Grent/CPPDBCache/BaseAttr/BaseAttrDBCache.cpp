/********************************************************************************************
* Copyright (C), 2011-2025, AGAN Tech. Co., Ltd.
* FileName:     BaseAttrDBCache.cpp
* Author:       甘业清
* Description:  基础数据数据类
* Version:      1.0
* History:
* <author>  <time>   <version >   <desc>
* 
********************************************************************************************/

#include "BaseAttrDBCache.h"
#include "BASE.h"


IMPLEMENT_INSTANCE(DataBaseAttr);

//基础数据实现类构造函数
DataBaseAttr::DataBaseAttr()
{
	m_mapDataWraperVersionName[1] = "BaseAttrUserDataWraperV1";
	
}

//基础数据实现类析构函数
DataBaseAttr::~DataBaseAttr()
{

}


//获取模块ID
UINT8 DataBaseAttr::GetModuleId()
{
	return MODULE_ID_BASEATTR;
}

//获取模块名字
TStr DataBaseAttr::GetModuleName()
{
	return "BaseAttr";
}

//获取模块同步(保存)数据版本及类名
map<INT32,TStr> DataBaseAttr::GetDataWraperVersionName()
{

	return m_mapDataWraperVersionName;
}

//模块同步(保存)数据升级函数
bool DataBaseAttr::UpdateModuleData(ModuleDataInterface* pre, ModuleDataInterface* cur )
{
	
	return true;
}
//模块数据保存类型
SavedDataTypeE	DataBaseAttr::GetSavedDataType()
{
	return SAVE_USER_DATA;
}

//是否保存数据到数据库中
bool DataBaseAttr::IsSaveModuleDataToDB()
{

	return false;
}

//增量更新通知
bool DataBaseAttr::OnIncrementUpdate( INT64 key, int syncId, int Index, const char* pBuffer, int dataLen )
{
	BaseAttrUserDataWraperV1* pDataWraper = (BaseAttrUserDataWraperV1*)GetModuleData(key);
	if( pDataWraper == NULL )
	{
		assert(false);
		return false;
	}
	
	INT64 lValue = 0;
	int   iValue = 0;
	
	switch (syncId)
	{
	case SYNCID_BASEATTR_EXP:
	case SYNCID_BASEATTR_LEVEL:
	case SYNCID_BASEATTR_SERVERTIME:
	case SYNCID_BASEATTR_ROLEID:
	case SYNCID_BASEATTR_STRENGTH:
	case SYNCID_BASEATTR_AGILITY:
	case SYNCID_BASEATTR_INTELLECTUAL:
	case SYNCID_BASEATTR_ENDURANCE:
	case SYNCID_BASEATTR_SPIRIT:
	case SYNCID_BASEATTR_HP:
	case SYNCID_BASEATTR_MAXHP:
	case SYNCID_BASEATTR_PHYSICATTACK:
	case SYNCID_BASEATTR_PHYSICDEFENSE:
	case SYNCID_BASEATTR_MAGICATTACK:
	case SYNCID_BASEATTR_MAGICDEFENSE:
	case SYNCID_BASEATTR_HIT:
	case SYNCID_BASEATTR_HITRATE:
	case SYNCID_BASEATTR_MISS:
	case SYNCID_BASEATTR_MISSRATE:
	case SYNCID_BASEATTR_CRITICAL:
	case SYNCID_BASEATTR_CRITICALRATE:
	case SYNCID_BASEATTR_TENACITY:
	case SYNCID_BASEATTR_TENACITYRATE:
	case SYNCID_BASEATTR_PENET:
	case SYNCID_BASEATTR_PENETRATE:
	case SYNCID_BASEATTR_DODG:
	case SYNCID_BASEATTR_DODGRATE:
	case SYNCID_BASEATTR_CRITICALADDITION:
	case SYNCID_BASEATTR_CRITICALADDITIONRATE:
	case SYNCID_BASEATTR_CRITICALIMMUNE:
	case SYNCID_BASEATTR_CRITICALIMMUNERATE:
	case SYNCID_BASEATTR_MISSLEVEL:
	case SYNCID_BASEATTR_CRITICALLEVEL:
	case SYNCID_BASEATTR_DODGLEVEL:
	case SYNCID_BASEATTR_MOVESPEED:
	case SYNCID_BASEATTR_DIZZYSTATE:
	case SYNCID_BASEATTR_GODSTATE:
	case SYNCID_BASEATTR_CANTMOVESTATE:
	case SYNCID_BASEATTR_PHYSICADDITION:
	case SYNCID_BASEATTR_MAGICADDITION:
	case SYNCID_BASEATTR_PHYSICOPPOSE:
	case SYNCID_BASEATTR_MAGICOPPOSE:
	case SYNCID_BASEATTR_ACCUMULATESKIENERGY:
	case SYNCID_BASEATTR_NICKNAME:
		pDataWraper->SetNickName(string(pBuffer,dataLen));
		break;
	case SYNCID_BASEATTR_CONFIGID:
	case SYNCID_BASEATTR_OBJTYPE:
	case SYNCID_BASEATTR_STATE:
	case SYNCID_BASEATTR_OWNEROBJID:
	case SYNCID_BASEATTR_CAMP:
	case SYNCID_BASEATTR_SILVERMONEY:
	case SYNCID_BASEATTR_GOLDMONEY:
	case SYNCID_BASEATTR_DIAMONDMONEY:
	case SYNCID_BASEATTR_BINDINGDIAMONDMONEY:
	case SYNCID_BASEATTR_BATTLESCORE:
	case SYNCID_BASEATTR_ENERGY:
	case SYNCID_BASEATTR_GUILDMONEY:
	case SYNCID_BASEATTR_SKILLLIST:
	case SYNCID_BASEATTR_HONORMONEY:
	case SYNCID_BASEATTR_RESOURCEPOOLHP:
	case SYNCID_BASEATTR_ATTACKADD:
	case SYNCID_BASEATTR_INJURYADD:
	case SYNCID_BASEATTR_FROZENSTATE:
	case SYNCID_BASEATTR_SILENTSTATE:
	case SYNCID_BASEATTR_GUILDCONTRIBUTEHISTORYMAX:
	case SYNCID_BASEATTR_TEAMID:
	case SYNCID_BASEATTR_TREASUREHAIR:
	case SYNCID_BASEATTR_TREASUREHEAD:
	case SYNCID_BASEATTR_TREASUREBODY:
	case SYNCID_BASEATTR_TREASUREWEAPON:
	case SYNCID_BASEATTR_TREASUREWING:
	case SYNCID_BASEATTR_GUILDGUID:
	case SYNCID_BASEATTR_TREASURERIDING:
	case SYNCID_BASEATTR_VECHICLEID:
	case SYNCID_BASEATTR_ANIMATIONSTATE:
	case SYNCID_BASEATTR_REFIXDMGRATE:
	case SYNCID_BASEATTR_REFIXDMGVALUE:
	case SYNCID_BASEATTR_REFIXHURTRATE:
	case SYNCID_BASEATTR_REFIXHURTVALUE:
	case SYNCID_BASEATTR_REFIXHEALRATE:
	case SYNCID_BASEATTR_REFIXHEALVALUE:
	case SYNCID_BASEATTR_REFIXCUREDRATE:
	case SYNCID_BASEATTR_REFIXCUREDVALUE:
	case SYNCID_BASEATTR_GUILDCONTRIBUTE:
	case SYNCID_BASEATTR_PVPMONEY:
	case SYNCID_BASEATTR_GUILDRESOURCE:
	case SYNCID_BASEATTR_CREATEROLETIME:
	case SYNCID_BASEATTR_UPDATEROLETIME:
	case SYNCID_BASEATTR_FIGHTSTATE:
	case SYNCID_BASEATTR_ATTACKSKILLLIST:
	case SYNCID_BASEATTR_GUILDNAME:
		pDataWraper->SetGuildName(string(pBuffer,dataLen));
		break;
	case SYNCID_BASEATTR_ISALLOWSELECT:
	case SYNCID_BASEATTR_GOHOMESTATE:
	case SYNCID_BASEATTR_CANFIGHT:
	case SYNCID_BASEATTR_DOUBLEEXP:
	case SYNCID_BASEATTR_FRIENDPOINT:
	case SYNCID_BASEATTR_HISMAXHONOR:
	case SYNCID_BASEATTR_HURTSTATE:
	case SYNCID_BASEATTR_HURTFLYSTATE:
	case SYNCID_BASEATTR_HURTDOWNSTATE:
	case SYNCID_BASEATTR_HURTREPELSTATE:
	case SYNCID_BASEATTR_TODAYHORNOR:
	case SYNCID_BASEATTR_CURPROFESSION:

	default:
		break;
	}
	pDataWraper->OnDataChange();
	lValue ++;
	iValue ++;
	return true;
}
