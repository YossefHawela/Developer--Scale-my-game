using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageWriter : HIdeShowGO
{
    public static MessageWriter Instance;

    private void Awake()
    {
        Instance= this;
    }

}
