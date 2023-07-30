using Naninovel;
using UnityEngine.EventSystems;

public class PointerDownPlayScript : PlayScript, IPointerDownHandler
{
    public void OnPointerDown(PointerEventData eventData)
    {
        Play();
    }
}
