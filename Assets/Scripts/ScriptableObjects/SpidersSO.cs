using UnityEngine;

[CreateAssetMenu(menuName = "Bugs/Spiders")]
public class SpidersSO : ScriptableObject
{
    public Sprite spidersIcon;
    public AudioClip spidersSound;
    public string spidersName;
    public int spidersCurrentHealth;
    public int spidersMaxHealth;
    public int spidersDamage;
    public GameObject spidersPrefab;
}
