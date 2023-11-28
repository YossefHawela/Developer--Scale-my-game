using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MessageWriter : HIdeShowGO
{
    public static MessageWriter Instance;
    [SerializeField]
    private TMP_InputField WriteMessageTextBox;
    [SerializeField]
    private Button SendButton;

    private string WriteMessageTextBoxTextvalue;
    private void Awake()
    {
        Instance= this;

        WriteMessageTextBox.onValueChanged.AddListener((value) =>
        {
            WriteMessageTextBoxTextvalue = value;
        });
    }

    public void SupmitMessage()
    {
        if (WriteMessageTextBox.text != "") 
        {
            MessagesContainer.Instance.AddMessage(new Message() { Content = WriteMessageTextBoxTextvalue, date = System.DateTime.Now, IsPlayersMessage = true });
            TaleeBot.Instance.DoAction(WriteMessageTextBoxTextvalue);
            WriteMessageTextBox.text = "";
        }
    }

    public void SetTextboxText(string text)
    {
        WriteMessageTextBox.text = text;
        WriteMessageTextBoxTextvalue = text;

    }
    public void DeActiveWriteMessageTextBox()
    {
        WriteMessageTextBox.enabled= false;
    }

    public void ActivateWriteMessageTextBox() 
    {
        WriteMessageTextBox.enabled= true;
    }
    public void DeActiveSendButton()
    {
        SendButton.enabled = false;
    }

    public void ActivateSendButton()
    {
        SendButton.enabled = true;
    }
}
