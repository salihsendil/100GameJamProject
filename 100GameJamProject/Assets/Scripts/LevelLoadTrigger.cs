using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLoadTrigger : MonoBehaviour
{
    LevelLoader levelLoader;

    void Start()
    {
        levelLoader = FindObjectOfType<LevelLoader>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player")) {
            levelLoader.LoadNextScene();
        }
    }
}