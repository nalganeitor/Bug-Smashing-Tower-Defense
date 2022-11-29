using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class CardController : MonoBehaviour
{
    private GameObject selectedObject;
    [SerializeField] private Transform cardOrigin;
    [SerializeField] private float backToOriginSpeed;
    [SerializeField] private TextMeshPro cardDescription;

    Vector3 offset;

    void Update()
    {

        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            Collider2D targetObject = Physics2D.OverlapPoint(mousePosition);

            if (targetObject == GetComponent<Collider2D>())
            {
                selectedObject = targetObject.transform.gameObject;
                offset = selectedObject.transform.position - mousePosition;
            }
        }
        else
        {
            transform.position = Vector2.Lerp(transform.position, cardOrigin.position, Time.deltaTime * backToOriginSpeed);
        }
        if (selectedObject)
        {
            selectedObject.transform.position = mousePosition + offset;
        }
        if (Input.GetMouseButtonUp(0) && selectedObject)
        {
            selectedObject = null;
        }
    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag == "Unit")
        {
            cardDescription.text = collision.GetComponent<UnitDisplay>().unit.fireCardDescription;

            if (Input.GetMouseButtonUp(0))
            {
                collision.GetComponent<UnitDisplay>().onFire.SetActive(true);
                Destroy(gameObject);
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Unit")
        {
            cardDescription.text = "Hover over an item to see this card's effect.";
        }
    }
}
