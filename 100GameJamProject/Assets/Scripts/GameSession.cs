using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameSession : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI scoreText;
    [SerializeField] public int letterNumber = 0;   
    [SerializeField] public int collectedLetter = 0;   
    

    void Start()
    {
        scoreText.text = collectedLetter.ToString() + " / " + letterNumber;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateLetterAndText()
    {
        //ui letter will add
        collectedLetter++;
        scoreText.text = collectedLetter.ToString() + " / " + letterNumber;
    }
}
