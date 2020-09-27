/*gxb********************************************************************************************
* Copyright (C), 2011-2025, Ambition. Co., Ltd.
* FileName:     ModuleDungeon.cpp
* Author:       郭晓波
* Description:  副本类，包含以下内容
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

#include "DungeonModule.h"



//初始化
bool ModuleDungeon::Initialize()
{

	
	return OnLoad();
}

bool ModuleDungeon::Reinitialize()
{
	
	return OnLoad();
}
