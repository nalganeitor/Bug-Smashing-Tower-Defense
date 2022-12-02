using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoachesManager : MonoBehaviour
{
    [SerializeField] RoachesSO roaches;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Girl"))
        {
            other.GetComponent<GirlManager>().TakeDamage(roaches.roachesDamage);

            Destroy(this.gameObject);
        }
    }

    public void TakeDamage(int _damage)
    {
        roaches.roachesCurrentHealth -= _damage;

        if (roaches.roachesCurrentHealth <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("roach dead");
    }
}
