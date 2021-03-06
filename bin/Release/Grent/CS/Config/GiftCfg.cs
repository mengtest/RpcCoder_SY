﻿using UnityEngine;
using GenPB;
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;


//礼物表配置数据类
public class GiftElement
{
	public int id;               	//礼物ID	礼物对应的ID
	public string comment;       	//注释	策划用
	public int item_id;          	//道具ID	对应道具表中的ID
	public int gift_ytpe;        	//礼物类型	1：人气礼物 2：好友度礼物

	public bool IsValidate = false;
	public GiftElement()
	{
		id = -1;
	}
};

//礼物表配置封装类
public class GiftTable
{

	private GiftTable()
	{
		m_mapElements = new Dictionary<int, GiftElement>();
		m_emptyItem = new GiftElement();
		m_vecAllElements = new List<GiftElement>();
	}
	private Dictionary<int, GiftElement> m_mapElements = null;
	private List<GiftElement>	m_vecAllElements = null;
	private GiftElement m_emptyItem = null;
	private static GiftTable sInstance = null;

	public static GiftTable Instance
	{
		get
		{
			if( sInstance != null )
				return sInstance;	
			sInstance = new GiftTable();
			return sInstance;
		}
	}

	public GiftElement GetElement(int key)
	{
		if( m_mapElements.ContainsKey(key) )
			return m_mapElements[key];
		return null;
	}

	public int GetElementCount()
	{
		return m_mapElements.Count;
	}
	public bool HasElement(int key)
	{
		return m_mapElements.ContainsKey(key);
	}

  public List<GiftElement> GetAllElement(Predicate<GiftElement> matchCB = null)
	{
        if( matchCB==null || m_vecAllElements.Count == 0)
            return m_vecAllElements;
        return m_vecAllElements.FindAll(matchCB);
	}

	public bool Load()
	{
		
		string strTableContent = "";
		if( GameAssist.ReadCsvFile("Gift.csv", out strTableContent ) )
			return LoadCsv( strTableContent );
		byte[] binTableContent = null;
		if( !GameAssist.ReadBinFile("Gift.bin", out binTableContent ) )
		{
			Ex.Logger.Log("配置文件[Gift.bin]未找到");
			return false;
		}
		return LoadBin(binTableContent);
	}


	public bool LoadBin(byte[] binContent)
	{
		m_mapElements.Clear();
		m_vecAllElements.Clear();
		int nCol, nRow;
		int readPos = 0;
		readPos += GameAssist.ReadInt32Variant( binContent, readPos, out nCol );
		readPos += GameAssist.ReadInt32Variant( binContent, readPos, out nRow );
		List<string> vecLine = new List<string>(nCol);
		List<int> vecHeadType = new List<int>(nCol);
        string tmpStr;
        int tmpInt;
		for( int i=0; i<nCol; i++ )
		{
            readPos += GameAssist.ReadString(binContent, readPos, out tmpStr);
            readPos += GameAssist.ReadInt32Variant(binContent, readPos, out tmpInt);
            vecLine.Add(tmpStr);
            vecHeadType.Add(tmpInt);
		}
		if(vecLine.Count != 4)
		{
			Ex.Logger.Log("Gift.csv中列数量与生成的代码不匹配!");
			return false;
		}
		if(vecLine[0]!="id"){Ex.Logger.Log("Gift.csv中字段[id]位置不对应"); return false; }
		if(vecLine[1]!="comment"){Ex.Logger.Log("Gift.csv中字段[comment]位置不对应"); return false; }
		if(vecLine[2]!="item_id"){Ex.Logger.Log("Gift.csv中字段[item_id]位置不对应"); return false; }
		if(vecLine[3]!="gift_ytpe"){Ex.Logger.Log("Gift.csv中字段[gift_ytpe]位置不对应"); return false; }

		for(int i=0; i<nRow; i++)
		{
			GiftElement member = new GiftElement();
			readPos += GameAssist.ReadInt32Variant(binContent, readPos, out member.id );
			readPos += GameAssist.ReadString( binContent, readPos, out member.comment);
			readPos += GameAssist.ReadInt32Variant(binContent, readPos, out member.item_id );
			readPos += GameAssist.ReadInt32Variant(binContent, readPos, out member.gift_ytpe );

			member.IsValidate = true;
			m_vecAllElements.Add(member);
			m_mapElements[member.id] = member;
		}
		return true;
	}
	public bool LoadCsv(string strContent)
	{
		if( strContent.Length == 0 )
			return false;
		m_mapElements.Clear();
		m_vecAllElements.Clear();
		int contentOffset = 0;
		List<string> vecLine;
		vecLine = GameAssist.readCsvLine( strContent, ref contentOffset );
		if(vecLine.Count != 4)
		{
			Ex.Logger.Log("Gift.csv中列数量与生成的代码不匹配!");
			return false;
		}
		if(vecLine[0]!="id"){Ex.Logger.Log("Gift.csv中字段[id]位置不对应"); return false; }
		if(vecLine[1]!="comment"){Ex.Logger.Log("Gift.csv中字段[comment]位置不对应"); return false; }
		if(vecLine[2]!="item_id"){Ex.Logger.Log("Gift.csv中字段[item_id]位置不对应"); return false; }
		if(vecLine[3]!="gift_ytpe"){Ex.Logger.Log("Gift.csv中字段[gift_ytpe]位置不对应"); return false; }

		while(true)
		{
			vecLine = GameAssist.readCsvLine( strContent, ref contentOffset );
			if((int)vecLine.Count == 0 )
				break;
			if((int)vecLine.Count != (int)4)
			{
				return false;
			}
			GiftElement member = new GiftElement();
			member.id=Convert.ToInt32(vecLine[0]);
			member.comment=vecLine[1];
			member.item_id=Convert.ToInt32(vecLine[2]);
			member.gift_ytpe=Convert.ToInt32(vecLine[3]);

			member.IsValidate = true;
			m_vecAllElements.Add(member);
			m_mapElements[member.id] = member;
		}
		return true;
	}
};
