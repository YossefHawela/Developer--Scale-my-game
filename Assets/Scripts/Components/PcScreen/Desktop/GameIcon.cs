using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameIcon : ClickableIcon
{
    public override Action action 
    {
        get
        {
            return delegate 
            {
                GameContainer.Instance.Show();
                Desktop.Instance.ActiveControlBox();
                Desktop.Instance.Hide();

                Game.Instance.StartGame();

                Desktop.Instance.SetControlBoxExitButtonEvent(delegate
                {
                    Game.Instance.ExitGame();
                    Desktop.Instance.Show();
                    Desktop.Instance.DeActiveControlBox();

                });
            };
        }

    }
}
