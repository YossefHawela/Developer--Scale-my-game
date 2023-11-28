using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Account : MonoBehaviour
{

    private List<Message> messages = new List<Message>();

    public Message[] GetMessages()
    {
        return messages.OrderBy(m=>m.date).ToArray();
    }
}
