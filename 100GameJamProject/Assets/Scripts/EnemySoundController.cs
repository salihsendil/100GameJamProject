using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySoundController : MonoBehaviour
{
    AudioSource audioSource;
    Animator animator;
    CharacterController characterController;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        characterController = GetComponent<CharacterController>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (characterController.velocity != Vector3.zero) {
            audioSource.enabled = true;
        }
        else {
            audioSource.enabled = false;
        }
    }
}
