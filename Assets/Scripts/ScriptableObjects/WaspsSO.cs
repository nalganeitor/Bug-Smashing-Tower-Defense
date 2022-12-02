using UnityEngine;

[CreateAssetMenu(menuName = "Bugs/Wasps")]
public class WaspsSO : ScriptableObject
{
    public Sprite waspsIcon;
    public AudioClip waspsSound;
    public string waspsName;
    public int waspsCurrentHealth;
    public int waspsMaxHealth;
    public int waspsDamage;
    public GameObject waspsPrefab;
}
