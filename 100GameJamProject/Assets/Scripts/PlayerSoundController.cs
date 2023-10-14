using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSoundController : MonoBehaviour
{
    AudioSource audioSource;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.velocity != Vector2.zero) {
            audioSource.enabled = true;
        }
        else {
            audioSource.enabled = false;
        }
    }
}
