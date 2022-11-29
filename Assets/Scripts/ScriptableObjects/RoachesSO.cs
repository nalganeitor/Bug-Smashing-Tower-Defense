using UnityEngine;

[CreateAssetMenu(menuName = "Bugs/Roaches")]
public class RoachesSO : ScriptableObject
{
    public Sprite roachesIcon;
    public AudioClip roachesSound;
    public string roachesName;
    public int roachesHealth;
    public int roachesDamage;
    public GameObject roachesPrefab;
}
