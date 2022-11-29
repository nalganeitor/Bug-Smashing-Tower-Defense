using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntsInstantiate : MonoBehaviour
{
    [SerializeField] GameObject prefabPool1;
    [SerializeField] GameObject prefabPool2;
    [SerializeField] GameObject prefabPool3;
    float xpos1 = -191f;
    float ypos1 = 38f;
    float zpos1 = 0.7342163f;
    float xpos2 = -141f;
    float ypos2 = 53f;
    float zpos2 = 0.7342163f;
    float xpos3 = -177f;
    float ypos3 = 86f;
    float zpos3 = 0.7342163f;
    float enemyCount;

    void Awake()
    {
        StartCoroutine(EnemyDrop());
    }

    IEnumerator EnemyDrop()
    {
        while (enemyCount < 5)
        {
            var copy1 = prefabPool1;
            var copy2 = prefabPool2;
            var copy3 = prefabPool3;

            Instantiate(copy1, new Vector3(xpos1, ypos1, zpos1), Quaternion.identity);
            Instantiate(copy2, new Vector3(xpos2, ypos2, zpos2), Quaternion.identity);
            Instantiate(copy3, new Vector3(xpos3, ypos3, zpos3), Quaternion.identity);
            yield return new WaitForSeconds(3);
            enemyCount += 1;
        }
    }
}
