using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MessageView : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI Content;


    public void SetText(string text)
    {
        Content.text = text;
    }
}
