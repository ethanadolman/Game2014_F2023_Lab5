using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonDetector : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private bool isButtonDown = false;

    public void OnPointerDown(PointerEventData eventData)
    {
        isButtonDown = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isButtonDown = false;
    }

    public bool IsButtonDown()
    {
        return isButtonDown;
    }
}