using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DecisionController : MonoBehaviour
{
    [Header("Expected Level")]
    [SerializeField]
    public string newLevel;
    [Header("Ending")]
    [SerializeField]
    public string endLevel;
    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON;

    public static DecisionController instance;

    bool firsttime = true;
    //bool iswrong = false;
    bool rightanswer = false;

    public void CallWrongAnswer(bool iswrong)
    {
        if (iswrong == true)
        {
            rightanswer = false;
        }
        else if (iswrong == false)
        {
            rightanswer = true;
        }
    }

    public void Update()
    {
        if (!DialogueManager.GetInstance().dialogueIsPlaying && firsttime == true)
        {
            InputManager.GetInstance().interactPressed = true;
            if (InputManager.GetInstance().GetInteractPressed())
            {
                DialogueManager.GetInstance().EnterDialogueMode(inkJSON);
                firsttime = false;
            }
        }
        if (DialogueManager.GetInstance().dialogueIsPlayed && firsttime == false && rightanswer == true)
        {
            Debug.Log("Trying to go to " + newLevel + " level");
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            SceneManager.LoadScene(newLevel);
        }
        if (DialogueManager.GetInstance().dialogueIsPlayed && firsttime == false && rightanswer == false)
        {
            Debug.Log("Trying to go to " + newLevel + " level");
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            SceneManager.LoadScene(endLevel);
        }
    }

    public static DecisionController GetInstance()
    {
        return instance;
    }

    /*public void InGameDialogueManager()
    {
        while ()
    }*/
}
