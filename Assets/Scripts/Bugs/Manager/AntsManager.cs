using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntsManager : MonoBehaviour
{
    [SerializeField] AntsSO ants;

    int health;
    int damage;

    // Start is called before the first frame update
    void Start()
    {
        health = ants.antsHealth;
        damage = ants.antsDamage;
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
