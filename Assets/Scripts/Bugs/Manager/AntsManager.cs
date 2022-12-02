using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntsManager : MonoBehaviour
{
    [SerializeField] AntsSO ants;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Girl"))
        {
            other.GetComponent<GirlManager>().TakeDamage(ants.antsDamage);
            Debug.Log("a");
            Destroy(this.gameObject);
        }
    }

    public void TakeDamage(int _damage)
    {
        ants.antsCurrentHealth -= _damage;

        if (ants.antsCurrentHealth <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("ant dead");
    }
}
