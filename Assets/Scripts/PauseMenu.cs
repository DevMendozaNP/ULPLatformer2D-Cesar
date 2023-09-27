using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject MenuPause;
    bool isPaused = false;

    public GameObject Button1;
    public GameObject Button2;
    public GameObject titleScreen;
    public GameObject playerUIs;

    private void OnPause(InputValue value)
    {
        if (isPaused == false)
        {
            MenuPause.SetActive(true);
            playerUIs.SetActive(false);
            isPaused = true;
            Time.timeScale = 0;
        }
        else
        {
            MenuPause.SetActive(false);
            playerUIs.SetActive(true);
            isPaused = false;
            Time.timeScale = 1;
        }
    }

    public void RestartOnClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
        titleScreen.SetActive(false);
        
    }
    
    public void QuitOnClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
