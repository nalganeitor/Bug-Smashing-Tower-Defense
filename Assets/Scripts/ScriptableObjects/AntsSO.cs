using UnityEngine;

[CreateAssetMenu(menuName = "Bugs/Ants")]
public class AntsSO : ScriptableObject
{
    public Sprite antsIcon;
    public AudioClip antsSound;
    public string antsName;
    public int antsHealth;
    public int antsDamage;
    public GameObject antsPrefab;
}
