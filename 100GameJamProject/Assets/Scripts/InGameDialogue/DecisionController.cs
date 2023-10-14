using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DecisionController : MonoBehaviour
{
    [Header("New Level")]
    [SerializeField]
    public string newLevel;
    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON;

    public void Update()
    {
        if (!DialogueManager.GetInstance().dialogueIsPlaying)
        {
            InputManager.GetInstance().interactPressed = true;
            if (InputManager.GetInstance().GetInteractPressed())
            {
                DialogueManager.GetInstance().EnterDialogueMode(inkJSON);
            }
        }
    }

    public void GameStart()
    {
        Debug.Log(newLevel + "level");
        SceneManager.LoadScene(newLevel);
    }

    /*public void InGameDialogueManager()
    {
        while ()
    }*/
}
