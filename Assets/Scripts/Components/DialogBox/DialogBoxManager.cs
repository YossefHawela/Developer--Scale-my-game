using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class DialogBoxManager : HIdeShowGO
{
    public static DialogBoxManager Instance;

    [SerializeField]
    private TextMeshProUGUI MessageContent;

    private UnityAction Action;

    private void Awake()
    {
        Instance = this;
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Action();
        }
    }
    /// <summary>
    /// Set the dialogs message content
    /// </summary>
    /// <param name="Content">new content</param>
    public void SetMessageContent(string Content)
    {
        MessageContent.text= Content;
    }
    public void SetActionAfterSpaceClicked(UnityAction action)
    {
        Action= action;
    }
}
