using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLoadTrigger : MonoBehaviour
{
    LevelLoader levelLoader;
    GameSession gameSession;

    void Awake()
    {
        levelLoader = FindObjectOfType<LevelLoader>();
        gameSession = FindObjectOfType<GameSession>();
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (gameSession.AllLettersCollected) {
            if (other.gameObject.CompareTag("Player")) {
                Debug.Log("Load trigger activated");
                levelLoader.LoadNextScene();
            }
        }
    }
}