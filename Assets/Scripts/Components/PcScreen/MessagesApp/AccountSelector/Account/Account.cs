using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Account : MonoBehaviour
{

    private List<Message> messages = new List<Message>() 
    {
        new Message() { IsPlayersMessage =true, date = DateTime.Now,Content="Hay Talee"},
        new Message() { IsPlayersMessage =true, date = DateTime.Now,Content="Talee"},
        new Message() { IsPlayersMessage =true, date = DateTime.Now,Content="Talee"},
        new Message() { IsPlayersMessage =true, date = DateTime.Now,Content="Talee"},
        new Message() { IsPlayersMessage =true, date = DateTime.Now,Content="Talee"},
        new Message() { IsPlayersMessage =true, date = DateTime.Now,Content="Talee"},
        new Message() { IsPlayersMessage =false, date = DateTime.Now,Content="What!"},




    };
    public Message[] GetMessages()
    {
        return messages.OrderBy(m=>m.date).ToArray();
    }
}
