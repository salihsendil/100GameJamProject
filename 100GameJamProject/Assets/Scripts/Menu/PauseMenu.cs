using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject gameOverMenu;
    public GameObject debugMenu;
    public bool isPaused;
    public bool isNoticed;
    public bool isDebug;
    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            if (isDebug)
            {
                ResumeGame();
            }
            else
            {
                DebugGame();
            }
        }
    }

    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        gameOverMenu.SetActive(false);
        Time.timeScale = 1f;
        isNoticed = false;
    }

    public void DebugGame()
    {
        debugMenu.SetActive(true);
        Time.timeScale = 0f;
        isDebug = true;
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        debugMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
        isDebug = false;
    }

    public void EndGame()
    {
        gameOverMenu.SetActive(true);
        Time.timeScale = 0f;
        isNoticed = true;
    }

    public void GoToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
        isPaused = false;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
