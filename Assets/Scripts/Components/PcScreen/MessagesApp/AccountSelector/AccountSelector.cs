using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccountSelector : HIdeShowGO
{
    public static AccountSelector Instance;

    public Account SelectedAccount;
    
    private void Awake()
    {
        Instance= this; 
    }
}
