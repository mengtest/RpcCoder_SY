/*gxb********************************************************************************************
* Copyright (C), 2011-2025, Ambition. Co., Ltd.
* FileName:     Module$Template$.cpp
* Author:       ������
* Description:  $ModCName$�࣬������������
*               ��ģ�������Ϣ����
*               ���ʼ�������ص�����
*               ��ʱ���൱�ص�����
*               ���û����������߻ص�����
*               ��ģ�������޸ļ�ͬ���ص�����
* Version:      1.0
* History:
* <author>  <time>   <version >   <desc>
* 
********************************************************************************************/

#include "$Template$Module.h"
$HeaderConfig$


//��ʼ��
bool Module$Template$::Initialize()
{

$LoadConfig$	
	OnLoad();
	return true;
}

bool Module$Template$::Reinitialize()
{
	$ReLoadConfig$
	OnLoad();
	return true;
}
