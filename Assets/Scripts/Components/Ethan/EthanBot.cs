using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EthanBot : MonoBehaviour
{

    public static EthanBot Instance;

    private void Awake()
    {
        Instance= this;
    }

    public void Start()
    {
        GeneralMetholds.instance.WaitToDo(() =>
        {
            DoAction("Game Start");
        }, 1);
    }

    /// <summary>
    /// Do action depending on spectific event
    /// </summary>
    /// <param name="Event"></param>
    public void DoAction(string Event)
    {
        switch (Event)
        {
            case "Game Start":
                DialogBoxManager.Instance.Show();
                DialogBoxManager.Instance.SetMessageContent(GetDialogMessage(Event));
                DialogBoxManager.Instance.SetActionAfterSpaceClicked(() => 
                {
                    DialogBoxManager.Instance.Hide();

                    GeneralMetholds.instance.WaitToDo(() =>
                    {
                        BlackScreenManager.Instance.Hide();
                    }, 0.5f);


                });

                break;
            default:
                break ;
        }
    }


    /// <summary>
    /// Return a dialog message depending on A Spectific svent
    /// </summary>
    /// <param name="Event"></param>
    /// <returns></returns>
    public string GetDialogMessage(string Event)
    {
        switch (Event)
        {
            case "Game Start":
                return "After waiting patiently for two long years, I finally got my hands on the game I had been eagerly anticipating. I had devoured every piece of information from my favorite game developer'Talee' reading notes and watching brief video teasers describing the game I had yearned for. The moment had finally come. My heart raced as I launched my pc, my excitement reaching its peak.";
            default:
                return "";
        }
    }
    /// <summary>
    /// Get the message and return a replay to it
    /// </summary>
    /// <param name="message"the message to replay to></param>
    /// <returns>the reply</returns>
    public string GetReply(string message)
    {
        return message;
    }
}
