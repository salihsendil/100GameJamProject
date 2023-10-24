using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VideoController : MonoBehaviour
{
    [SerializeField] public float waitTime;
    [SerializeField] public string levelChange;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitVideo());
    }

    IEnumerator WaitVideo()
    {
        yield return new WaitForSeconds(waitTime);
        SceneManager.LoadScene(levelChange);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SkipVideo();
        }
    }

    public void SkipVideo()
    {
        SceneManager.LoadScene(levelChange);
    }

}
