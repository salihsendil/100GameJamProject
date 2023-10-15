using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueButtonScript : MonoBehaviour
{

    [SerializeField] public bool wronganswer = false; //{ get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        /*Debug.Log(wronganswer + ": Doðru/Yanlýþ Cevap Sistemi");
        if (wronganswer == true && DialogueManager.GetInstance().dialogueIsPlayed)
        {
            DecisionController.GetInstance().CallWrongAnswer(true);
            Debug.Log("Yanlýþ cevaba týklandý");
        }
        else
        {
            DecisionController.GetInstance().CallWrongAnswer(false);
            Debug.Log("Doðru cevapta kalýndý");
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
