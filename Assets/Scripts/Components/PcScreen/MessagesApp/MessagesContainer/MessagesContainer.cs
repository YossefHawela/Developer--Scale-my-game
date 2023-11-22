using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessagesContainer : HIdeShowGO
{
    public static MessagesContainer Instance;

    private void Awake()
    {
        Instance = this;
    }
}
