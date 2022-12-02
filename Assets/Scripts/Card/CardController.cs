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
    LayerMask mask;

    Vector3 offset;

    private void Awake()
    {
        mask = LayerMask.GetMask("Card");
    }

    void Update()
    {
        MouseCardControl();
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


    void MouseCardControl()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Collider2D targetObject = Physics2D.OverlapPoint(mousePosition, mask);

        if (targetObject == GetComponent<Collider2D>())
        {
            if (Input.GetMouseButtonDown(0))
            {
                selectedObject = targetObject.transform.gameObject;
                offset = selectedObject.transform.position - mousePosition;
            }
            else
                 gameObject.transform.localScale = new Vector2(1.2f, 1.2f);
        }
        else
            gameObject.transform.localScale = new Vector2(1f, 1f);

        if (!Input.GetMouseButtonDown(0))
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