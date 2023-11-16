using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PcScreen : HIdeShowGO
{
    public static PcScreen Instance;



    private void Awake()
    {
        Instance = this;
    }

}
