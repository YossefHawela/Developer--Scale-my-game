using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameContainer : HIdeShowGO
{
    public static GameContainer Instance;

    private void Awake()
    {
        Instance= this;
    }
    
}
