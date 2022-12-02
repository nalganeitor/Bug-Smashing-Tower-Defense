using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpidersManager : MonoBehaviour
{
    [SerializeField] SpidersSO spiders;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Girl"))
        {
            other.GetComponent<GirlManager>().TakeDamage(spiders.spidersDamage);

            Debug.Log("test");

            Destroy(this.gameObject);
        }
    }

    public void TakeDamage(int _damage)
    {
        spiders.spidersCurrentHealth -= _damage;

        if (spiders.spidersCurrentHealth <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("spider dead");
    }
}
