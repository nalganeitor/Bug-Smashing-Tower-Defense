using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirlManager : MonoBehaviour
{
    [SerializeField] GirlSO girl;

    void Awake()
    {
        girl.girlCurrentHealth = girl.girlMaxHealth;
    }

    public void TakeDamage(int _damage)
    {
        girl.girlCurrentHealth -= _damage;

        if (girl.girlCurrentHealth <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
        //_animator.SetBool(_isDeadHash, true);
        Debug.Log("girl dead");
    }
}
