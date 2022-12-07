using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class References : MonoBehaviour
{
    public static Dictionary<string, dynamic> references = new();

    public static T GetReference<T>(string id)
    {
        if (references.ContainsKey(id))
            return references[id];

        return default(T);
    }

    public static bool AddReference(string id, dynamic reference)
    {
        if (references.ContainsKey(id))
            return false;

        references.Add(id, reference);
        return true;
    }

    public static void OverrideReference(string id, dynamic reference)
    {
        if (!references.ContainsKey(id))
            references.Add(id, reference);
        else
            references[id] = reference;

    }
}
