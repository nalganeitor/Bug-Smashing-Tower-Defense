using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseAndPlayManager : MonoBehaviour
{
    [SerializeField] private GameObject bugHolder, cardHolder, messageButton;

    public bool gameStarted = false;

    [SerializeField] private GameObject playButton;

    private void Awake()
    {
        //Disables the holders to ensure that the enemies don't start moving when the level is played
        //Useful when play testing and the holders are enabled in the editor.
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
        
    }

    public void GameStart()
    {
        bugHolder.SetActive(true);
        cardHolder.SetActive(true);
        playButton.SetActive(false);
        gameStarted = true;
    }

    public void HideMessage()
    {
        messageButton.SetActive(false);
        playButton.SetActive(true);
    }
}
