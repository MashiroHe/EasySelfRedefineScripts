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
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace EditorExtensions
{
    public class NamespaceSettings
    {
        private readonly static string Namespace_Key = Application.productName + "_NameSpace";
        public static string Namespace 
        {
            get => UnityEditor.EditorPrefs.GetString(Namespace_Key, defaultValue: "DefaultNamespace");
            set => UnityEditor.EditorPrefs.SetString(Namespace_Key, value);
        } 
        public static bool IsDefaultNamespace => Namespace == "DefaultNamespace";
    }
}

