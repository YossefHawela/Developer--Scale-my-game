using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desktop : HIdeShowGO
{
    public static Desktop Instance;

    private void Awake()
    {
        Instance= this; 
    }
}
