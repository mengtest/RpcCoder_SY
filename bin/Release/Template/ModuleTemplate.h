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
#include "Game/PacketMgr.h"
#include "$Template$Rpc.pb.h"
#include <memory>
#include <vector>
#include <functional>

$IncludeSyncDataHeader$


class CPlayer;
class CPacket;

extern std::unique_ptr<PacketMgr> g_pPacketMgr;

//$ModCName$ʵ����
class Module$Template$
{
	
public:
	//$ModCName$���ö�ٶ���
	enum Const$Template$E
	{
$DeclareMsgID$
	};

	typedef std::function<void()> ReloadCallback;
	typedef std::vector<ReloadCallback> reload_vec_type;
public:
	//$ModCName$ʵ���๹�캯��
	Module$Template$()
	{
$CliOperationImpl$
	}
	
	//$ModCName$ʵ������������
	~Module$Template$(){}


	static Module$Template$ & Instance()
	{
		static Module$Template$ sInstance;
		return sInstance;
	}
	
	bool Initialize();
	bool Reinitialize();

	void RegisterReLoadCb(const ReloadCallback &cb)
	{
		m_vReLoadCb.push_back(cb);
	}
	
	void OnLoad()
	{
			for (auto it : m_vReLoadCb)
		{
			it();
		}
	}
public:
$CliOperationDeclare$
	reload_vec_type m_vReLoadCb;

};

#endif