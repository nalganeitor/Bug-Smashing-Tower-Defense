using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoachesInstantiate : MonoBehaviour
{
    [SerializeField] GameObject prefabPool;
    float xpos = -191f;
    float ypos = 38f;
    float zpos = 0.7342163f;
    float enemyCount;

    void Awake()
    {
        StartCoroutine(EnemyDrop());
    }

    IEnumerator EnemyDrop()
    {
        while (enemyCount < 5)
        {
            var copy = prefabPool;

            Instantiate(copy, new Vector3(xpos, ypos, zpos), Quaternion.identity);
            yield return new WaitForSeconds(3);
            enemyCount += 1;
        }
    }
}
