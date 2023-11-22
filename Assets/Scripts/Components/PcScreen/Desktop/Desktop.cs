using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Desktop : HIdeShowGO
{
    public static Desktop Instance;

    [SerializeField]
    private ClickableIcon GameIcon;
    [SerializeField]
    private ClickableIcon MessageIcon;
    [SerializeField]
    private Transform ControlBox;
    [SerializeField]
    private Button ControlBoxExitButton;

    private void Awake()
    {
        Instance= this; 
    }

    public void ShowMessageIcon()
    {
        MessageIcon.gameObject.SetActive(true);
    }
    public void DeActiveGameIcon()
    {
        GameIcon.Deactive();
    }

    public void ActiveGameIcon()
    {
        GameIcon.Active();
    }

    public void DeActiveControlBox()
    {
        ControlBox.gameObject.SetActive(false);
    }

    public void ActiveControlBox()
    {
        ControlBox.gameObject.SetActive(true);
    }

    public void ActiveMessageIcon()
    {
        MessageIcon.Active();
    }
    public void DeActiveMessageIcon()
    {
        MessageIcon.Deactive();

    }

    public void SetControlBoxExitButtonEvent(UnityAction action)
    {
        ControlBoxExitButton.onClick.RemoveAllListeners();
        ControlBoxExitButton.onClick.AddListener(action);

    }


}
