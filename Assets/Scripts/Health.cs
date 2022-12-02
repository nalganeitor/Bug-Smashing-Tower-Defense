using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Health : MonoBehaviour
{
    [SerializeField] GirlSO girl;

    private TMP_Text m_TextComponent;

    void Awake()
    {
        m_TextComponent = GetComponent<TMP_Text>();
    }

    void Update()
    {
        m_TextComponent.text = girl.girlCurrentHealth.ToString();
    }
}
