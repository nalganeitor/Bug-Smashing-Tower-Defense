using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Unit", menuName = "Unit")]
public class UnitData : ScriptableObject
{
    public new string name;
    public string description;
    public string fireCardDescription;
    public string waterCardDescription;
    public string earthCardDescription;
    public string metalCardDescription;

    public Sprite artwork;

    public int cost;
}
