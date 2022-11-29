using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{
    public CardData card;
    public Sprite artwork;
    public Text cardName;
    public Text cardDescription;
    public Text powerText;
    public Text costText;
    // Start is called before the first frame update
    void Start()
    {
        artwork = card.artwork;
        cardName.text = card.name;
        cardDescription.text = card.description;
        powerText.text = card.power.ToString();
        costText.text = card.cost.ToString();
    }
}
