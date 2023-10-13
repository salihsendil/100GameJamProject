using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    PlayerInput playerInput;
    Vector2 movementInput;
    Vector2 movement;
    float moveSpeed = 5f;

    Rigidbody2D rb;

    Animator animator;
    int isWalkingHash;
    int animHorizontalHash;
    int animVerticalHash;

    private void Awake()
    {
        playerInput = new PlayerInput();
        playerInput.playerController.Move.started += OnMove;
        playerInput.playerController.Move.performed += OnMove;
        playerInput.playerController.Move.canceled += OnMove;

        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        animHorizontalHash = Animator.StringToHash("Horizontal");
        animVerticalHash = Animator.StringToHash("Vertical");
        isWalkingHash = Animator.StringToHash("isWalking");
    }

    void Update()
    {
        Debug.Log(movementInput);

        rb.velocity = movement;
        animator.SetFloat(animHorizontalHash, movement.x);
        animator.SetFloat(animVerticalHash, movement.y);
    }

    private void OnMove(InputAction.CallbackContext callback)
    {
        movementInput = callback.ReadValue<Vector2>();
        movement = movementInput * moveSpeed;//time.deltatime
        if (movement != Vector2.zero) {
            animator.SetBool(isWalkingHash, true);
        }
        else {
            animator.SetBool(isWalkingHash, false);
        }
    }

    private void OnEnable()
    {
        playerInput.playerController.Enable();
    }

    private void OnDisable()
    {
        playerInput.playerController.Disable();
    }
}
