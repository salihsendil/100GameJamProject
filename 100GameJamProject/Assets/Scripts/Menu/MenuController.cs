using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public string newLevel;
    [SerializeField]
    
    public void GameStart()
    {
        Debug.Log(newLevel + "level");
        SceneManager.LoadScene(newLevel);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ExitButton()
    {
        Application.Quit();
    }
}
