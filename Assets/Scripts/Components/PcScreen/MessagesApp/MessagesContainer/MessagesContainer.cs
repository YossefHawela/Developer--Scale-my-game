using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MessagesContainer : HIdeShowGO
{
    public static MessagesContainer Instance;

    [SerializeField]
    private Transform Content;
    [SerializeField]
    private ScrollRect react;
    [SerializeField]
    private Transform TaleeMessagePrefap;

    [SerializeField]
    private Transform PlayerMessagePrefap;


    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        LoadMessages();
    }

    public void LoadMessages()
    {
        Clear();

        Message[] messages = AccountSelector.Instance.SelectedAccount.GetMessages();

        for (int i = 0; i < messages.Length; i++)
        {
            Message m = messages[i];

            if (m != null)
            {
                MessageView messageView;
                if (m.IsPlayersMessage)
                {
                    messageView = Instantiate(PlayerMessagePrefap, Content).GetComponent<MessageView>();
                }
                else
                {
                    messageView = Instantiate(TaleeMessagePrefap, Content).GetComponent<MessageView>();

                }

                if (messageView)
                {
                    messageView.SetText(m.Content);
                }
            }
        }

        react.verticalNormalizedPosition = 0;
    }

    private void Clear()
    {
        for (int i = 0; i < Content.childCount; i++)
        {
            Destroy(Content.GetChild(0).gameObject);
        }
    }

    public void AddMessage(Message m)
    {
        if (m != null)
        {
            MessageView messageView;
            if (m.IsPlayersMessage)
            {
                messageView = Instantiate(PlayerMessagePrefap, Content).GetComponent<MessageView>();
            }
            else
            {
                messageView = Instantiate(TaleeMessagePrefap, Content).GetComponent<MessageView>();

            }

            if (messageView)
            {
                messageView.SetText(m.Content);
            }
        }

        ScrollDown();
    }

    public void ScrollDown()
    {
        if (gameObject.activeInHierarchy)
            StartCoroutine(IEscrollDown());
    }
    private IEnumerator IEscrollDown()
    {
        do
        {
            react.verticalNormalizedPosition -= 0.1f;
            yield return new WaitForEndOfFrame();

        } while (react.verticalNormalizedPosition > 0);
    }



}
