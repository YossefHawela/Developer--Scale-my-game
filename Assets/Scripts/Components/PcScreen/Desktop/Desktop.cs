using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desktop : HIdeShowGO
{
    public static Desktop Instance;

    [SerializeField]
    private ClickableIcon GameIcon;
    [SerializeField]
    private ClickableIcon MessageIcon;


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

    public void ActiveMessageIcon()
    {
        MessageIcon.Active();
    }
    public void DeActiveMessageIcon()
    {
        MessageIcon.Deactive();

    }
}
