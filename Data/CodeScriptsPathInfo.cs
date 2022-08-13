/****************************************************************************
 * Copyright (c) 2022 ~  MashiroHe MIT License
 *
 * EasySelfRedefineScripts
 *
 * git@github.com:MashiroHe/EasySelfRedefineScripts.git
 * 
 * Author:
 *  MashiroHe       https://github.com/MashiroHe
 *
 * Contributor
 * 
*
 * Community
 *  QQ : 1967407707@qq.com
 * Latest Update: 2022.8.12 9:23 repair  spawn code format
 ****************************************************************************/
/********************************************************************
created:  2022/1/15  16:15
filename: CodeGenerateInfo.cs
author:	  Mashiro Shiina
e-mail address:1967407707@qq.com
filefullpath:G:/MGDemo/EditorExtensions/Assets/EditorExtensions/Data/CodeGenerateInfo.cs
purpose:    
********************************************************************/
using UnityEngine;
using UnityEngine.UI;

namespace EditorExtensions
{
	[ExecuteInEditMode]
	public class CodeScriptsPathInfo : MonoBehaviour
	{
		[HideInInspector]
		public string m_ScriptsFolderPath;
		[HideInInspector]
		public bool IsSpawnPrefab = false;
		[HideInInspector]
		public string m_PrefabFolderPath;
		 private void Awake()
		 {
			m_ScriptsFolderPath = "Assets/Scripts/UI/Common";
			m_PrefabFolderPath = "Assets/GameData/Prefabs";
		 }
	}
}
