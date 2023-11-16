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
                Game.Instance.StartGame();
            };
        }

    }
}
