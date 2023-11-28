using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class Icon : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Image image;

    private void Awake()
    {
        image = GetComponent<Image>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Color cl = image.color;
        image.color = new Color(cl.r, cl.g, cl.b,100/255f);
    }

    
    public void OnPointerExit(PointerEventData eventData)
    {
        Color cl = image.color;
        image.color = new Color(cl.r, cl.g, cl.b, 1/255f);
    }

}
