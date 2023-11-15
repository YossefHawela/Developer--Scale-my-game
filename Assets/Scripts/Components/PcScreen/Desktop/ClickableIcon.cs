using UnityEngine.EventSystems;

public  class ClickableIcon : Icon, IPointerClickHandler
{
    public virtual System.Action action { get; }
    public void OnPointerClick(PointerEventData eventData)
    {
        if(action is not null)
            action();
    }

}
