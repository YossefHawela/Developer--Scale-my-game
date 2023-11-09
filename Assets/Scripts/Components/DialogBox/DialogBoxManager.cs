using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogBoxManager : HIdeShowGO
{
    public static DialogBoxManager Instance;

    [SerializeField]
    private TextMeshProUGUI MessageContent;

    private void Awake()
    {
        Instance = this;
    }
    /// <summary>
    /// Set the dialogs message content
    /// </summary>
    /// <param name="Content">new content</param>
    public void SetMessageContent(string Content)
    {
        MessageContent.text= Content;
    }
}
