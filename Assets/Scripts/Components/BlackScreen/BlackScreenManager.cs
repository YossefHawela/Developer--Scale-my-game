using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackScreenManager : HIdeShowGO
{
    public static BlackScreenManager Instance;

    private void Awake()
    {
        Instance= this;
    }
}
