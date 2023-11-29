using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamesCenter : MonoBehaviour
{
    public static GamesCenter Instance;

    public Transform StarterGame;

    public Transform BigWhiteRoom;

    private void Awake()
    {
        Instance = this;
    }
}
