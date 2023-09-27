using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class TitleScreen : MonoBehaviour
{
    public GameObject titleScreen;
    bool isPlaying = false;

    public GameObject startButton;
    public GameObject playerUIs;

    private void Start()
    {
        Time.timeScale = 0;
        playerUIs.SetActive(false);
        
    }

    public void PlayOnClick()
    {
        if(isPlaying == false)
        {
            titleScreen.SetActive(false);
            isPlaying = true;
            Time.timeScale = 1;
            playerUIs.SetActive(true);
        }
        if(isPlaying == true)
        {

        }
    }

}
