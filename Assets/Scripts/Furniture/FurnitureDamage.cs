using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FurnitureDamage : MonoBehaviour
{
    private UnitDisplay unitDisplay;

    private void Awake()
    {
        unitDisplay = gameObject.GetComponent<UnitDisplay>();
    }

    public void OnTriggerStay2D(Collider2D collision)
    {
        if (unitDisplay.onFire.activeInHierarchy && collision.tag == "Bug")
            collision.GetComponent<SpriteRenderer>().color = new Color (255, 0, 0, 255);
    }
}
