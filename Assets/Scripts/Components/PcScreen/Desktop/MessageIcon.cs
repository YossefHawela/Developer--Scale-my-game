using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

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
