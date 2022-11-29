using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpidersManager : MonoBehaviour
{
    [SerializeField] SpidersSO spiders;

    int health;
    int damage;

    // Start is called before the first frame update
    void Start()
    {
        health = spiders.spidersHealth;
        damage = spiders.spidersDamage;
    }

    // Update is called once per frame
    void Update()
    {
        Click();
    }

    public void Click()
    {
        if (Input.GetKeyUp(KeyCode.Q))
        {
            Debug.Log(health);
            Debug.Log(damage);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            health++;
            damage++;
        }
    }
}
