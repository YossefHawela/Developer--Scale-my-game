using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessagesAppManager : HIdeShowGO
{
    public static MessagesAppManager Instance;
    private void Awake()
    {
        Instance = this;
    }


}
