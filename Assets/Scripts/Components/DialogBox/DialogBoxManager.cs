using System;
using TMPro;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class DialogBoxManager : HIdeShowGO
{
    public static DialogBoxManager Instance;

    [SerializeField]
    private TextMeshProUGUI MessageContent;

    private Action Action;

    private Action LastAction;

    private void Awake()
    {
        Instance = this;
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {

            if (Action != null && LastAction!= Action)
            {
                LastAction = Action;
                Action();

            }


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
    public void SetActionAfterSpaceClicked(Action action)
    {
        Action = action;
        
    }
}
