using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccountSelector : HIdeShowGO
{
    public static AccountSelector Instance;

    private void Awake()
    {
        Instance= this; 
    }
}
