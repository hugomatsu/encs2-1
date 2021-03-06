﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDView : MonoBehaviour
{

    //[Serializable]
    //public class SpawnButton
    //{
    //    public Text m_TextAmount;
    //    public Image m_Texture;
    //    public Button m_Button;
    //}

    [Header("Kill Count")]
    [SerializeField] Animator m_KillCountController;
    [SerializeField] private Text m_TextKillCount;
    [SerializeField] private Text m_TextUnitPlayerCount;
    [SerializeField] private Text m_TextUnitEnemyCount;
    [Header("Spawn Buttons")]
    [SerializeField] private SpawnButton m_ButtonSpawnTemplate;
    [SerializeField] private SpawnButton[] m_Buttons;

    private void OnDestroy()
    {
        for (int i = 0; i < m_Buttons.Length; i++)
        {
            m_Buttons[i].Setup(null, null);
        }
    }

    public void Setup()
    {

    }

    #region core methods
    public void SetKillAmount(int iAmount)
    {
        m_TextKillCount.text = iAmount.ToString();
        m_KillCountController.SetTrigger("OnScore");
    }
    public void SetPlayerUnitAmount(int iAmount)
    {
        m_TextUnitPlayerCount.text = iAmount.ToString();
    }
    public void SetEnemyUnitAmount(int iAmount)
    {
        m_TextUnitEnemyCount.text = iAmount.ToString();
    }
    public void SetOnClick(int iIdx, System.Action PointerDown, System.Action PointerUp)
    {
        m_Buttons[iIdx].Setup(PointerDown, PointerUp);
    }
    public void SetEnabled(int iIdx, bool bEnabled)
    {
        m_Buttons[iIdx].m_Button.interactable = bEnabled;
    }
    public void SetAmount(E_MechaPart pPartType, int iAmount)
    {
        m_Buttons[(int)pPartType].m_TextAmount.text = iAmount.ToString();
    }
    #endregion
}
