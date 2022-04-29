using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    public GameObject AudioSettingsUI;
    public GameObject MainMenuUI; 

    public void PlayGame()
    {
        SceneManager.LoadScene("Space");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void GoToAudioSettings()
    {
        AudioSettingsUI.SetActive(true);
    }

    public void Back()
    {
        AudioSettingsUI.SetActive(false);
        MainMenuUI.SetActive(true);
    }
}
