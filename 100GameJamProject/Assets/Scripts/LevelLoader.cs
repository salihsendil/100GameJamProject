using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    Animator animator;
    int isNextSceneLoading;
    int isSceneLoaded;
    [SerializeField] string nextSceneName;
    public GameObject repair;

    void Awake()
    {
        animator = GetComponent<Animator>();
        isNextSceneLoading = Animator.StringToHash("isNextSceneLoading");
        isSceneLoaded = Animator.StringToHash("isSceneLoaded");
        StartCoroutine(FadeInDelay());
    }

    public void LoadNextScene()
    {
        StartCoroutine(FadeOutDelay());
    }

    private void FadeInTrigger()
    {
        animator.SetBool(isNextSceneLoading, true);
        animator.SetBool(isSceneLoaded, false);
    }

    private void FadeOutTrigger()
    {
        animator.SetBool(isNextSceneLoading, false);
        animator.SetBool(isSceneLoaded, true);
    }

    public void DisableRepair()
    {
        if (repair) repair.SetActive(false);
    }

    public void EnableRepair()
    {
        if (repair) repair.SetActive(true);
    }

    IEnumerator FadeOutDelay()
    {
        FadeOutTrigger();
        yield return new WaitForSeconds(5f);
        StartCoroutine(LoadScene(nextSceneName));
    }

    IEnumerator FadeInDelay()
    {
        FadeInTrigger();
        yield return new WaitForSeconds(5f);
        animator.SetBool(isNextSceneLoading, false);
        animator.SetBool(isSceneLoaded, false);
    }

    IEnumerator LoadScene(string sceneName)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneName);
        operation.allowSceneActivation = false;

        while (!operation.isDone) {
            float progress = Mathf.Clamp01(operation.progress / 0.9f);

            if (progress >= 1.0f) {
                operation.allowSceneActivation = true;
            }

            yield return null;
        }
    }
}
