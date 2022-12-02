using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UnitDisplay : MonoBehaviour
{
    public UnitData unit;

    public GameObject artwork;
    public GameObject onFire;

    public TextMeshPro description;
    public TextMeshPro fireCardDescription;
    public TextMeshPro waterCardDescription;
    public TextMeshPro earthCardDescription;
    public TextMeshPro metalCardDescription;

    // Start is called before the first frame update
    void Start()
    {
        artwork.GetComponent<SpriteRenderer>().sprite = unit.artwork;

        //fireCardDescription.text = unit.fireCardDescription;
    }
}
