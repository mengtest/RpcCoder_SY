/********************************************************************************************
* Copyright (C), 2011-2025, Ambition. Co., Ltd.
* FileName:     Module$Template$.h
* Author:       ������
* Description:  $ModCName$�࣬������������
*               ��ģ�������Ϣ����
*               ���ʼ�������ص�����
*               ��ʱ���൱�ص�����
*               ���û����������߻ص�����
*               ��ģ�������޸ļ�ͬ���ص�����
*               ���������̨RPC����
*               ��ͻ���RPC����
* Version:      1.0
* History:
* <author>  <time>   <version >   <desc>
* 
********************************************************************************************/

#ifndef __MODULE_$TEMPLATE$_H
#define __MODULE_$TEMPLATE$_H


#include "PacketFactory.h"
#include "include/PacketMgr.h"
#include "$Template$Rpc.pb.h"


$IncludeSyncDataHeader$
$HeaderConfig$

class CPlayer;
class CPacket;

extern PacketMgr* g_pPacketMgr;

//$ModCName$ʵ����
class Module$Template$
{
	
public:
	//$ModCName$���ö�ٶ���
	enum Const$Template$E
	{
$DeclareMsgID$
	};

public:
	//$ModCName$ʵ���๹�캯��
	Module$Template$()
	{
$CliOperationImpl$
	}
	
	//$ModCName$ʵ������������
	~Module$Template$(){}


	

public:
$CliOperationDeclare$

};

#endif