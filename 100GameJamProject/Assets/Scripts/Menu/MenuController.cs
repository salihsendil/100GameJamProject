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
    }

    public void ExitButton()
    {
        Application.Quit();
    }
}
