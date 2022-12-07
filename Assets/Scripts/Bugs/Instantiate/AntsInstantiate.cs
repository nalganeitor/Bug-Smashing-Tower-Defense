using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntsInstantiate : MonoBehaviour
{
    [SerializeField] GameObject antPrefabVariation1;
    [SerializeField] GameObject antPrefabVariation2;
    [SerializeField] GameObject antPrefabVariation3;

    Vector3 spawnPos1 = new(-191f, 38f, 0.7342163f);
    Vector3 spawnPos2 = new(-141f, 53f, 0.7342163f);
    Vector3 spawnPos3 = new(-177f, 86f, 0.7342163f);

    float enemyCount;

    void Awake()
    {
        StartCoroutine(EnemyDrop());
    }

    IEnumerator EnemyDrop()
    {
        while (enemyCount < 5)
        {
            Instantiate(antPrefabVariation1, spawnPos1, Quaternion.identity);
            Instantiate(antPrefabVariation2, spawnPos2, Quaternion.identity);
            Instantiate(antPrefabVariation3, spawnPos3, Quaternion.identity);
            yield return new WaitForSeconds(3);
            enemyCount += 1;
        }
    }
}
