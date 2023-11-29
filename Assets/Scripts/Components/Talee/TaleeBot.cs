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
                    SendAMessage(Event);
                    DoAction("the deal");
                }, 0.5f);
                break;
            case "the deal":
                GeneralMetholds.instance.WaitToDo(delegate
                {
                    SendAMessage(Event);
                    WaitForAnotherMessage(Event);
                }, 1.2f);
                break;
            case "What?! Are you kidding me? \nTwo years of anticipation for a white room? \nThat's not cool, \nit's incredibly frustrating and disappointing!":
                WaitForAnotherMessage(Event);
                break;
            case "I expected so much more from you talee. \nThis isn't what I signed up for. \nI need answers, not sarcasm.":
                GeneralMetholds.instance.WaitToDo(delegate
                {
                    SendAMessage(Event);
                    DoAction("Update Game To Big White Room");
                }, 0.5f);
                break;
            case "Update Game To Big White Room":
                Game.Instance.GamePrefap = GamesCenter.Instance.BigWhiteRoom;
                GameConstraints.Instance.IsGamePaused = false;
                Desktop.Instance.ActiveGameIcon();
                break;
            case "Talee's Message":

                SendAMessage(Event);
                WaitForAnotherMessage(Event);

                break;
            case "oh yeah sure":
                GeneralMetholds.instance.WaitToDo(delegate 
                {
                    SendAMessage("See ^-^");
                    WaitForAnotherMessage(Event);
                },0.5f);
                break;
            case "Seriously? A bigger white room? \nIs this some kind of joke? \nI was expecting an epic adventure":
                WaitForAnotherMessage(Event);
                break;
            case "Not an endless stroll through a white void. \nThis is beyond disappointing. \nTalee, you've got to be kidding me!":
                WaitForAnotherMessage(Event);
                break;
            case "I need more than just space to walk \nI need a game with substance, challenges, and excitement.":
                WaitForAnotherMessage(Event);
                break;
            case "Please tell me this is just another prank \nAnd there's more to this than meets the eye!":
               
                GeneralMetholds.instance.WaitToDo(delegate
                {
                    SendAMessage("Haha, you're sharp, Ethan");

                    DoAction("Haha, you're sharp, Ethan");
                }, 1.5f);
                break;
            case "Haha, you're sharp, Ethan":
                GeneralMetholds.instance.WaitToDo(delegate
                {
                    SendAMessage("You caught me again");

                    DoAction("You caught me again");
                }, 1.5f);
                break;
            case "You caught me again":
                GeneralMetholds.instance.WaitToDo(delegate
                {
                    SendAMessage("The bigger white room was just a distraction. \nI've already uploaded a new update with more models, \nchallenges, and excitement.");

                    DoAction("The bigger white room was just a distraction. \nI've already uploaded a new update with more models, \nchallenges, and excitement.");
                }, 1.5f);
                break;
            case "The bigger white room was just a distraction. \nI've already uploaded a new update with more models, \nchallenges, and excitement.":
                GeneralMetholds.instance.WaitToDo(delegate
                {
                    SendAMessage("Your patience will be rewarded this time. \nDive back in and see what surprises await you! \nEnjoy the real adventure now!");
                    DoAction("Platforms Game");

                }, 0.5f);
                break;  
            case "Platforms Game":

                Desktop.Instance.ActiveGameIcon();
                GameConstraints.Instance.IsGamePaused = false;
                //change game
                break;
            default:
                break;
        }
    }


    private void SendAMessage(string Message)
    {
        MessagesContainer.Instance.AddMessage(new Message() { Content = GetReply(Message) });
        SoundManager.Instance.CreateAudioSource(SoundManager.Instance.ReciveMessageSound);
    }
    public string GetReply(string message)
    {
        switch (message)
        {
            case "Is this a glitch? iam Really confused and disappointed.\n Can you please help?":
                return "Haha, you caught me! So here's the deal";
            case "the deal":
                return "the entire game accidentally got deleted,\nbut my genius mind decided a white room \nis the epitome of cool minimalism!\nso what do you need more than a white room?";
            case "I expected so much more from you talee. \nThis isn't what I signed up for. \nI need answers, not sarcasm.":
                return "Haha, gotcha! Just messing with you Ethan \nI couldn't resist the prank.\n Seriously though, check out the game now. \nI might have added a few surprises to that white room. \nEnjoy the adventure!";
            case "Talee's Message":
                return "If A tiny white room is cool then \nA bigger white room is cooler right?";
            default:
                return message;
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
            case "Talee's Message":
                EthanBot.Instance.DoAction("BiggerWhiteRoom?Why?");
                break;
            case "oh yeah sure":
                EthanBot.Instance.DoAction(Event);
                break;

            case "Seriously? A bigger white room? \nIs this some kind of joke? \nI was expecting an epic adventure":
                EthanBot.Instance.DoAction(Event);
                break;
            case "Not an endless stroll through a white void. \nThis is beyond disappointing. \nTalee, you've got to be kidding me!":
                EthanBot.Instance.DoAction(Event);
                break;
            case "I need more than just space to walk \nI need a game with substance, challenges, and excitement.":
                EthanBot.Instance.DoAction(Event);
                break;
            default:
                break;
        }
    }
}
