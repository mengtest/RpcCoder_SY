/********************************************************************************************
* Copyright (C), 2011-2025, AGAN Tech. Co., Ltd.
* FileName:     CliRpcRankImp.cpp
* Author:       甘业清
* Description:  排行榜类，包含以下内容
*               ★客户端RPC函数
* Version:      1.0
* History:
* <author>  <time>   <version >   <desc>
* 
********************************************************************************************/
#include "RankModule.h"
#include "MsgStreamMgr.h"


/********************************************************************************************
* Function:       RpcRank
* Description:    排行榜-->请求排行榜同步调用操作函数
* Input:          RankRpcRankAskWraper& Ask 请求排行榜请求
* Output:         RankRpcRankReplyWraper& Reply 请求排行榜回应
* Return:         int 高16位为系统返回值RpcCallErrorCodeE，获取方法GET_RPC_ERROR_CODE(ret) 
*                     低16位为操作返回值，获取方法GET_OPERATION_RET_CODE(ret)
********************************************************************************************/
static int ModuleRank::RpcRank( CPlayer* pPlayer, CPacket* pPacket)
{

	//逻辑代码


	//设置返回结果
	Reply.SetResult(0);
	return 0;
}



