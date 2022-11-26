using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Item : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject HighlightTable;

    public void OnPointerEnter(PointerEventData eventData)
    {
        HighlightTable.SetActive(true);
        Debug.Log("fire");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        HighlightTable.SetActive(false);
        Debug.Log("no fire");
    }

    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
        }
    }
}
