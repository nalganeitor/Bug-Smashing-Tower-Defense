using UnityEngine;

[CreateAssetMenu(menuName = "Players/Girl")]
public class GirlSO : ScriptableObject
{
    public Sprite girlIcon;
    public AudioClip girlSound;
    public string girlName;
    public int girlCurrentHealth;
    public int girlMaxHealth;
    public GameObject girlPrefab;
}
