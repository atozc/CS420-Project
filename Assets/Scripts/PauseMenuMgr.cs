using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuMgr : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public GameObject audioMenuUI;

    // Update is called once per frame
    void Update()
    {
      
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0;
    }

    public void AudioSettings()
    {
        audioMenuUI.SetActive(true);
    }

    public void Back()
    {
        audioMenuUI.SetActive(false);
        pauseMenuUI.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Space");
        Resume();
    }

    public void ExitGame()
    {
        SceneManager.LoadScene("MainMenu");
        Resume();
    }
}
