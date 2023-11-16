using UnityEngine.EventSystems;

public  class ClickableIcon : Icon, IPointerClickHandler
{
    public virtual System.Action action { get; }

    private bool IsClickable = true; 
    
    public void OnPointerClick(PointerEventData eventData)
    {
        if(action is not null&&IsClickable)
            action();
    }

    public void Active()
    {
        IsClickable = true;
    }
    public void Deactive()
    {
        IsClickable = false;
    }
}
