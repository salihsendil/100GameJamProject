using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneSelector : MonoBehaviour
{
    PauseMenu pausemenu;

    public string scene;
    //public Text levelText;
    // Start is called before the first frame update
    void Start()
    {
        //levelText.text = level.ToString();
    }

    public void OpenScene()
    {
        SceneManager.LoadScene(scene);
        //pausemenu.ResumeGame();
        //pausemenu.isDebug = false;
        Time.timeScale = 1f;
    }
}
