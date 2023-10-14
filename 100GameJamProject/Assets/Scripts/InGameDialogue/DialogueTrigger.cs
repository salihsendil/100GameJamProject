using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DialogueTrigger : MonoBehaviour
{
    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON;
    public string newLevel;
    [SerializeField]

    private bool playerInRange;

    public void Awake()
    {
        InputManager.GetInstance().interactPressed = true;

        DialogueManager.GetInstance().EnterDialogueMode(inkJSON);
    }

    private void Update()
    {

    }

    public void GameStart()
    {
        Debug.Log(newLevel + "level");
        SceneManager.LoadScene(newLevel);
    }
}
