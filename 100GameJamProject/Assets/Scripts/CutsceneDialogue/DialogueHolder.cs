using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace DialogueSystem
{
    public class DialogueHolder : MonoBehaviour
    {


        public string nextlevel;
        private IEnumerator dialogueSeq;
        [SerializeField] bool dialogueFinished;

        private void OnEnable()
        {
            dialogueSeq = dialogueSequence();
            StartCoroutine(dialogueSeq);
        }
        private void Update()
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                Deactivate();
                gameObject.SetActive(false);
                StopCoroutine(dialogueSeq);
            }
        }

        private IEnumerator dialogueSequence()
        {
            if (!dialogueFinished)
            {
                for (int i = 0; i < transform.childCount ; i++)
                {
                    Deactivate();
                    transform.GetChild(i).gameObject.SetActive(true);
                    
                        
                    
                    yield return new WaitUntil(() => transform.GetChild(i).GetComponent<DialogueLine>().finished);
                    if (i==3)
                    {
                        SceneManager.LoadScene(nextlevel);
                    }
                    Debug.Log(i);
                    //
                    dialogueFinished = true;
                }
                
            }
            else
            {
                Debug.Log("else");
                int index = transform.childCount - 1;
                Deactivate();
                transform.GetChild(index).gameObject.SetActive(true);
                yield return new WaitUntil(() => transform.GetChild(index).GetComponent<DialogueLine>().finished);
                SceneManager.LoadScene(nextlevel);
            }

            //dialogueFinished = true;
            //gameObject.SetActive(false);
        }

        private void Deactivate()
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                transform.GetChild(i).gameObject.SetActive(false);
            }
        }

        /*public void LevelTransition()
        {
            SceneManager.LoadScene(nextlevel);
        }*/
    }
}