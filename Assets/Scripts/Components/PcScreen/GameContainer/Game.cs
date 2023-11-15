using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public static Game Instance;

    public Transform GamePrefap;

    private void Awake()
    {
        Instance = this;
    }


    public void StartGame()
    {
        Instantiate(GamePrefap,transform);
    }
    public void ExitGame()
    {
        Transform game = transform.GetChild(0);

        if (game)
        {
            Destroy(game);
        }
    }

}
