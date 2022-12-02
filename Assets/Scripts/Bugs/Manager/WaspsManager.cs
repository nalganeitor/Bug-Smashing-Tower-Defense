using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaspsManager : MonoBehaviour
{
    [SerializeField] WaspsSO wasps;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Girl"))
        {
            other.GetComponent<GirlManager>().TakeDamage(wasps.waspsDamage);

            Destroy(this.gameObject);
        }
    }

    public void TakeDamage(int _damage)
    {
        wasps.waspsCurrentHealth -= _damage;

        if (wasps.waspsCurrentHealth <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("wasp dead");
    }
}

