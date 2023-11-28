using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.UI;

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
                        PcScreen.Instance.Show();
                    }, 0.5f);


                });
                break;
            case "betrayal":
                DialogBoxManager.Instance.Show();
                DialogBoxManager.Instance.SetMessageContent(GetDialogMessage(Event));
                DialogBoxManager.Instance.SetActionAfterSpaceClicked(() =>
                {
                    DialogBoxManager.Instance.Hide();
                    DoAction("clicking sounds");
                });
                break;
            case "clicking sounds":

                AudioClip ac = SoundManager.Instance.ClickClackSound;
                SoundManager.Instance.CreateAudioSource(ac);

                GeneralMetholds.instance.WaitToDo(delegate
                {
                    DoAction("I clicked every button");
                }, ac.length + 1);
                break;
            case "I clicked every button":

                DialogBoxManager.Instance.Show();
                DialogBoxManager.Instance.SetMessageContent(GetDialogMessage(Event));
                DialogBoxManager.Instance.SetActionAfterSpaceClicked(() =>
                {
                    DoAction("What had gone wrong?");
                   
                });
                break;
            case "What had gone wrong?":

                DialogBoxManager.Instance.Show();

                DialogBoxManager.Instance.SetMessageContent(GetDialogMessage(Event));

                DialogBoxManager.Instance.SetActionAfterSpaceClicked(() =>
                {
                    DoAction("I refuse");

                });
                break;
            case "I refuse":
                DialogBoxManager.Instance.SetMessageContent(GetDialogMessage(Event));
                DialogBoxManager.Instance.SetActionAfterSpaceClicked(() =>
                {
                    DoAction("I actually know the developer");
                });
                break;
            case "I actually know the developer":
                DialogBoxManager.Instance.SetMessageContent(GetDialogMessage(Event));
                DialogBoxManager.Instance.SetActionAfterSpaceClicked(() =>
                {
                    DialogBoxManager.Instance.Hide();
                    Cursor.lockState = CursorLockMode.None;
                    Cursor.visible = true;
                    //Game.Instance.ExitGame();
                    //Desktop.Instance.Show();
                    Desktop.Instance.ShowMessageIcon();
                    Desktop.Instance.DeActiveGameIcon();
                    MessagesAppManager.Instance.Show();
                    MessageWriter.Instance.SetTextboxText(GetDialogMessage("I just lunched"));
                    MessagesAppManager.Instance.Hide();


                });
                break;
            case "I just launched your game 'talee,'\n And it's showing a blank white room with no gameplay.":               
                GeneralMetholds.instance.WaitToDo(delegate 
                {
                    MessageWriter.Instance.SetTextboxText(GetDialogMessage("I just launched your game 'talee,'\n And it's showing a blank white room with no gameplay."));
                }, 0.5f);
                break;
            case "the deal":
                GeneralMetholds.instance.WaitToDo(delegate
                {
                    MessageWriter.Instance.SetTextboxText(GetDialogMessage("What?"));
                }, 1.5f);
                break;
            case "What?! Are you kidding me? \nTwo years of anticipation for a white room? \nThat's not cool, \nit's incredibly frustrating and disappointing!":
                GeneralMetholds.instance.WaitToDo(delegate
                {
                    MessageWriter.Instance.SetTextboxText(GetDialogMessage(Event));
                }, 0.5f);
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
            case "betrayal":
                return " How could this be? After two years of anticipation, all I found was an empty, featureless room? It felt like a cruel joke, a betrayal of the hopes and dreams I had built around this game.";
            case "I clicked every button":
                return "I clicked every button, hoping for a response, but there was nothing, The game remained stubbornly unresponsive, mocking my anticipation";
            case "What had gone wrong?":
                return "What had gone wrong? Was this a glitch, or had the game been released in this incomplete state? I couldn't comprehend how something I had looked forward to for so long had turned into such a bitter disappointment.";
            case "I refuse":
                return "I refuse to accept this as the end of my gaming journey. I have to reach out to the developers for an explanation or a solution, this was just a misunderstanding, that there was still a chance for the epic adventures I had imagined for sure.";
            case "I actually know the developer":
                return "I actually know the developer of the game, We had connected through online forums and shared our enthusiasm for gaming, i will close the game and message him. ";
            case "I just lunched":
                return "I just launched your game 'talee,'\n And it's showing a blank white room with no gameplay.";
            case "I just launched your game 'talee,'\n And it's showing a blank white room with no gameplay.":
                return "Is this a glitch? iam Really confused and disappointed.\n Can you please help?";
            case "What?":
                return "What?! Are you kidding me? \nTwo years of anticipation for a white room? \nThat's not cool, \nit's incredibly frustrating and disappointing!";
            case "What?! Are you kidding me? \nTwo years of anticipation for a white room? \nThat's not cool, \nit's incredibly frustrating and disappointing!":
                return "I expected so much more from you talee. \nThis isn't what I signed up for. \nI need answers, not sarcasm.";
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
