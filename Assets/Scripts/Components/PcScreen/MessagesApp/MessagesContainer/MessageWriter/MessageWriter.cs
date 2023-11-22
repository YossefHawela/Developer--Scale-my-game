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
    private void Awake()
    {
        Instance= this;
    }

    public void SupmitMessage(TextMeshProUGUI textMeshProUGUI)
    {
        MessagesContainer.Instance.AddMessage(new Message() { Content = textMeshProUGUI.text, date = System.DateTime.Now, IsPlayersMessage = true });
        textMeshProUGUI.text = "";
    }

    public void SetTextboxText(string text)
    {
        WriteMessageTextBox.text = text;
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
