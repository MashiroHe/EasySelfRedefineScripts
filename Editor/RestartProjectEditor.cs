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
created:  2022/1/17  0:2
filename: RestartProjectEditor.cs
author:	  Mashiro Shiina
e-mail address:1967407707@qq.com
filefullpath:G:/MGDemo/EditorExtensions/Assets/EditorExtensions/Editor/RestartProjectEditor.cs
purpose:    实现一键重启项目
********************************************************************/
using UnityEngine;
using UnityEditor;

namespace EditorExtensions
{
	public class RestartProjectEditor 
	{
		[MenuItem("Tools/EditorExtensions/Settings/RestartProject")]
		public static void DoRestartProject()
        {
			EditorApplication.OpenProject(Application.dataPath + "/../");
        }
	}
}
