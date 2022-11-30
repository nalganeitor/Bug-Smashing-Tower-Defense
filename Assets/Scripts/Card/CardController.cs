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
        DragAndDropCard();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        ActivateCardPower(collision);
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Unit")
        {
            cardDescription.text = "Hover over an item to see this card's effect.";
        }
    }


    void DragAndDropCard()
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
            print("wow");
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

    void ActivateCardPower(Collider2D collision)
    {
        if (collision.tag == "Unit")
        {
            GetCardDescription(collision);

            if (Input.GetMouseButtonUp(0))
            {
                collision.GetComponent<UnitDisplay>().onFire.SetActive(true);
                Destroy(gameObject);
            }
        }
    }

    void GetCardDescription(Collider2D collision)
    {
        if (gameObject.tag == "FireCard")
            cardDescription.text = collision.GetComponent<UnitDisplay>().unit.fireCardDescription;
        else if(gameObject.tag == "WaterCard")
            cardDescription.text = collision.GetComponent<UnitDisplay>().unit.waterCardDescription;
        else if(gameObject.tag == "EarthCard")
            cardDescription.text = collision.GetComponent<UnitDisplay>().unit.earthCardDescription;
        else if(gameObject.tag == "MetalCard")
            cardDescription.text = collision.GetComponent<UnitDisplay>().unit.metalCardDescription;
    }
}