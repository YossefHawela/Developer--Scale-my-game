using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Message 
{
    public DateTime date;
    public string Content;
    public bool IsPlayersMessage = false;
}
