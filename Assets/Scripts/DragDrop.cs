using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour, IPointerDownHandler, IDragHandler, IBeginDragHandler, IEndDragHandler, IDropHandler
{
    private RectTransform rectTransform;

    public GameObject HighlightTable;

    [SerializeField] Canvas canvas;

    void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {

    }

    public void OnEndDrag(PointerEventData eventData)
    {

    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        HighlightTable.SetActive(true);
        Debug.Log("fire");
    }

    public void OnPointerDown(PointerEventData eventData)
    {

    }

    public void OnPointerExit(PointerEventData eventData)
    {
        HighlightTable.SetActive(false);
        Debug.Log("no fire");
    }

    public void OnDrop(PointerEventData eventData)
    {

    }
}
