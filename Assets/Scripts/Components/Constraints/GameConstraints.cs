using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameConstraints : MonoBehaviour
{
    public static GameConstraints Instance;

    public bool IsGamePaused = false;
    private void Awake()
    {
        Instance= this;
    }
}
