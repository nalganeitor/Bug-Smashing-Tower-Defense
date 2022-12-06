using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseAndPlayManager : MonoBehaviour
{
    [SerializeField] private GameObject bugHolder, cardHolder, messageButton;

    public bool gameStart;

    [SerializeField] private GameObject playButton;

    private void Awake()
    {
        bugHolder.SetActive(false);
        cardHolder.SetActive(false);
        playButton.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameStart)
        {
            bugHolder.SetActive(true);
            cardHolder.SetActive(true);
            playButton.SetActive(false);
        }
    }


    public void GameStart()
    {
        gameStart = true;
    }

    public void HideMessage()
    {
        messageButton.SetActive(false);
        playButton.SetActive(true);
    }
}
