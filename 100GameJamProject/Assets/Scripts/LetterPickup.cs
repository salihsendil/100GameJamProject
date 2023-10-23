using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterPickup : MonoBehaviour
{
    [SerializeField] AudioClip letterSound;
    bool wasLetterCollected = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.isTrigger) {
            wasLetterCollected = true;
            FindObjectOfType<GameSession>().UpdateLetterAndText();
            AudioSource.PlayClipAtPoint(letterSound, Camera.main.transform.position, 0.5f);
            gameObject.SetActive(false);
            Destroy(gameObject);
        }

    }
}
