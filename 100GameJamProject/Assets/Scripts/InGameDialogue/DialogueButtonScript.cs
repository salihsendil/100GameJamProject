using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueButtonScript : MonoBehaviour
{

    [SerializeField] public bool wronganswer = false; //{ get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        /*Debug.Log(wronganswer + ": Do�ru/Yanl�� Cevap Sistemi");
        if (wronganswer == true && DialogueManager.GetInstance().dialogueIsPlayed)
        {
            DecisionController.GetInstance().CallWrongAnswer(true);
            Debug.Log("Yanl�� cevaba t�kland�");
        }
        else
        {
            DecisionController.GetInstance().CallWrongAnswer(false);
            Debug.Log("Do�ru cevapta kal�nd�");
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
