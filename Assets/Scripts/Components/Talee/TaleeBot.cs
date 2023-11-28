using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaleeBot : MonoBehaviour
{
    public static TaleeBot Instance;

    private void Awake()
    {
        Instance = this;
    }
    public void DoAction(string Event)
    {
        switch (Event)
        {
            case "I just launched your game 'talee,'\n And it's showing a blank white room with no gameplay.":
                WaitForAnotherMessage(Event);
                break;
            case "Is this a glitch? iam Really confused and disappointed.\n Can you please help?":
                GeneralMetholds.instance.WaitToDo(delegate 
                {
                    MessagesContainer.Instance.AddMessage(new Message() { Content = GetReply(Event) });
                    DoAction("the deal");
                }, 0.5f);
                break;
            case "the deal":
                GeneralMetholds.instance.WaitToDo(delegate
                {
                    MessagesContainer.Instance.AddMessage(new Message() { Content = GetReply(Event) });
                    WaitForAnotherMessage(Event);
                }, 1.2f);
                break;
            case "What?! Are you kidding me? \nTwo years of anticipation for a white room? \nThat's not cool, \nit's incredibly frustrating and disappointing!":
                WaitForAnotherMessage(Event);
                break;
            default:
                break;
        }
    }


    public string GetReply(string message)
    {
        switch (message)
        {
            case "Is this a glitch? iam Really confused and disappointed.\n Can you please help?":
                return "Haha, you caught me! So here's the deal";
            case "the deal":
                return "the entire game accidentally got deleted,\nbut my genius mind decided a white room \nis the epitome of cool minimalism!\nso what do you need more than a white room?";
            default:
                return "";
        }
    }

    private void WaitForAnotherMessage(string Event)
    {
        switch (Event)
        {
            case "I just launched your game 'talee,'\n And it's showing a blank white room with no gameplay.":
                EthanBot.Instance.DoAction(Event);
                break;
            case "the deal":
                EthanBot.Instance.DoAction(Event);
                break;
            case "What?! Are you kidding me? \nTwo years of anticipation for a white room? \nThat's not cool, \nit's incredibly frustrating and disappointing!":
                EthanBot.Instance.DoAction(Event);
                break;
            default:
                break;
        }
    }
}
