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
using UnityEngine.EventSystems;

namespace EditorExtensions
{
    public class UIRoot : MonoBehaviour
    {
        #region Public  Field
        public Transform m_BG;
        public Transform m_Common;
        public Transform m_Forward;
        public Transform m_PopUI;

        public Canvas m_Canvas;
        #endregion

        #region Private Field
        [SerializeField]
        private EventSystem m_EventSystem;

        #endregion
    }
}
