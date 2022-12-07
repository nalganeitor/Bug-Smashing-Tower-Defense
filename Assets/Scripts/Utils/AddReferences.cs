using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Reference
{
    public string id;
    public dynamic reference;
}

public class AddReferences : MonoBehaviour
{
    public List<Reference> references;


    //Called from the GameStartSetup script
    public void SetupReferences()
    {
        foreach (var @ref in references)
        {
            References.AddReference(@ref.id, @ref.reference);
        }
    }
}
