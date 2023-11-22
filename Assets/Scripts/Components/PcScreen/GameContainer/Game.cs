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
        Desktop.Instance.Hide();

        Instantiate(GamePrefap,transform);
    }
    public void ExitGame()
    {
        Transform game = transform.GetChild(0);

        if (game)
        {
            Destroy(game.gameObject);
        }

        GameContainer.Instance.Hide();
        Desktop.Instance.DeActiveControlBox();
        Desktop.Instance.Show();
        
    }

}
