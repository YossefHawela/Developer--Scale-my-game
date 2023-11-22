using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageIcon : ClickableIcon
{
    public override Action action
    {
        get
        {
            return delegate
            {
                Desktop.Instance.ActiveControlBox();
                Desktop.Instance.Hide();

                MessagesAppManager.Instance.Show();
                Desktop.Instance.SetControlBoxExitButtonEvent(delegate 
                {
                    MessagesAppManager.Instance.Hide();
                    Desktop.Instance.Show();
                    Desktop.Instance.DeActiveControlBox();
                });
            };
        }

    }
}
