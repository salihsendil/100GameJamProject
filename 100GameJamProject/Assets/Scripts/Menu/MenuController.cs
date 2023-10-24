using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public string newLevel;
    [SerializeField]
    //public GameObject debugMenu;
    //public static bool isDebug = false;
    
    public void GameStart()
    {
        Debug.Log(newLevel + "level");
        SceneManager.LoadScene(newLevel);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    private void Awake()
    {
        Time.timeScale = 1f;
    }

    /*private void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            if (isDebug)
            {
                Resume();
            }
        }
        else
        {
            DebugMode();
        }
    }

    public void DebugMode()
    {
        debugMenu.SetActive(true);
        Time.timeScale = 0f;
        isDebug = true;
    }

    public void Resume()
    {
        debugMenu.SetActive(false);
        Time.timeScale = 1f;
        isDebug = false;
    }*/
    public void ExitButton()
    {
        Application.Quit();
    }
}
