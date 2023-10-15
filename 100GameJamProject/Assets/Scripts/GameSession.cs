using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Linq;

public class GameSession : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI scoreText; 
    [SerializeField] public int collectedLetter = 0;
    List<LetterPickup> letters = new List<LetterPickup>();
    bool allLettersCollected;

    //getter setter
    public bool AllLettersCollected { get => allLettersCollected; set => allLettersCollected = value; }

    void Start()
    {
        letters = FindObjectsOfType<LetterPickup>().ToList();
        scoreText.text = collectedLetter.ToString() + " / " + letters.Count;
    }

    // Update is called once per frame
    void Update()
    {
        if (collectedLetter == letters.Count) {
            allLettersCollected = true;
        }
        else {
            allLettersCollected = false;
        }
    }

    public void UpdateLetterAndText()
    {
        //ui letter will add
        collectedLetter++;
        scoreText.text = collectedLetter.ToString() + " / " + letters.Count;
    }
}
