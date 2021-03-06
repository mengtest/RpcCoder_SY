﻿using UnityEngine;
using GenPB;
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;


//角色姓氏配置数据类
public class NameLastNameElement
{
	public int id;               	//序号	序号 =种族*10000+序号
	public string comment;       	//备注	标记用
	public int race;             	//种族	用来区分随机名称的种族 暂时无作用 0.通用 1.人类 2.精灵 3.兽人 4.矮人
	public string sc;            	//中文文本	该条目对应的中文文本
	public string en;            	//英文文本	该条目对应的英文文本

	public bool IsValidate = false;
	public NameLastNameElement()
	{
		id = -1;
	}
};

//角色姓氏配置封装类
public class NameLastNameTable
{

	private NameLastNameTable()
	{
		m_mapElements = new Dictionary<int, NameLastNameElement>();
		m_emptyItem = new NameLastNameElement();
		m_vecAllElements = new List<NameLastNameElement>();
	}
	private Dictionary<int, NameLastNameElement> m_mapElements = null;
	private List<NameLastNameElement>	m_vecAllElements = null;
	private NameLastNameElement m_emptyItem = null;
	private static NameLastNameTable sInstance = null;

	public static NameLastNameTable Instance
	{
		get
		{
			if( sInstance != null )
				return sInstance;	
			sInstance = new NameLastNameTable();
			return sInstance;
		}
	}

	public NameLastNameElement GetElement(int key)
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

  public List<NameLastNameElement> GetAllElement(Predicate<NameLastNameElement> matchCB = null)
	{
        if( matchCB==null || m_vecAllElements.Count == 0)
            return m_vecAllElements;
        return m_vecAllElements.FindAll(matchCB);
	}

	public bool Load()
	{
		
		string strTableContent = "";
		if( GameAssist.ReadCsvFile("NameLastName.csv", out strTableContent ) )
			return LoadCsv( strTableContent );
		byte[] binTableContent = null;
		if( !GameAssist.ReadBinFile("NameLastName.bin", out binTableContent ) )
		{
			Ex.Logger.Log("配置文件[NameLastName.bin]未找到");
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
		if(vecLine.Count != 5)
		{
			Ex.Logger.Log("NameLastName.csv中列数量与生成的代码不匹配!");
			return false;
		}
		if(vecLine[0]!="id"){Ex.Logger.Log("NameLastName.csv中字段[id]位置不对应"); return false; }
		if(vecLine[1]!="comment"){Ex.Logger.Log("NameLastName.csv中字段[comment]位置不对应"); return false; }
		if(vecLine[2]!="race"){Ex.Logger.Log("NameLastName.csv中字段[race]位置不对应"); return false; }
		if(vecLine[3]!="sc"){Ex.Logger.Log("NameLastName.csv中字段[sc]位置不对应"); return false; }
		if(vecLine[4]!="en"){Ex.Logger.Log("NameLastName.csv中字段[en]位置不对应"); return false; }

		for(int i=0; i<nRow; i++)
		{
			NameLastNameElement member = new NameLastNameElement();
			readPos += GameAssist.ReadInt32Variant(binContent, readPos, out member.id );
			readPos += GameAssist.ReadString( binContent, readPos, out member.comment);
			readPos += GameAssist.ReadInt32Variant(binContent, readPos, out member.race );
			readPos += GameAssist.ReadString( binContent, readPos, out member.sc);
			readPos += GameAssist.ReadString( binContent, readPos, out member.en);

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
		if(vecLine.Count != 5)
		{
			Ex.Logger.Log("NameLastName.csv中列数量与生成的代码不匹配!");
			return false;
		}
		if(vecLine[0]!="id"){Ex.Logger.Log("NameLastName.csv中字段[id]位置不对应"); return false; }
		if(vecLine[1]!="comment"){Ex.Logger.Log("NameLastName.csv中字段[comment]位置不对应"); return false; }
		if(vecLine[2]!="race"){Ex.Logger.Log("NameLastName.csv中字段[race]位置不对应"); return false; }
		if(vecLine[3]!="sc"){Ex.Logger.Log("NameLastName.csv中字段[sc]位置不对应"); return false; }
		if(vecLine[4]!="en"){Ex.Logger.Log("NameLastName.csv中字段[en]位置不对应"); return false; }

		while(true)
		{
			vecLine = GameAssist.readCsvLine( strContent, ref contentOffset );
			if((int)vecLine.Count == 0 )
				break;
			if((int)vecLine.Count != (int)5)
			{
				return false;
			}
			NameLastNameElement member = new NameLastNameElement();
			member.id=Convert.ToInt32(vecLine[0]);
			member.comment=vecLine[1];
			member.race=Convert.ToInt32(vecLine[2]);
			member.sc=vecLine[3];
			member.en=vecLine[4];

			member.IsValidate = true;
			m_vecAllElements.Add(member);
			m_mapElements[member.id] = member;
		}
		return true;
	}
};
