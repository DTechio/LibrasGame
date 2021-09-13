using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSlot : MonoBehaviour, IDropHandler
{
    [SerializeField] private RectTransform _transform;
    public int id;
    public void OnDrop(PointerEventData eventData)
    {

        if (eventData.pointerDrag.GetComponent<DragAndDrop>().id == id)
        {
            Debug.Log("Correto");
        }
        else
        {
            Debug.Log("Errado");
        }
        eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = _transform.anchoredPosition;
    }
}
