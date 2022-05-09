using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuMgr : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public GameObject audioMenuUI;

    public static bool isGamePaused = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isGamePaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        AudioListener.pause = false;
        isGamePaused = false;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        AudioListener.pause = true;
        isGamePaused = true;
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
