using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuImageManager : MonoBehaviour
{
    [SerializeField] Sprite[] diceImages;
    [SerializeField] SpriteRenderer spriteRenderer;
    int randomNumber;
    void Start()
    {
        RandomizeImages();
    }

    public void RandomizeImages()
    {
        randomNumber = Random.Range(1, diceImages.Length + 1);
        spriteRenderer.sprite = diceImages[randomNumber - 1];
        print(randomNumber);
    }

}
