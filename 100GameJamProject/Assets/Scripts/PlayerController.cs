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

    private void Awake()
    {
        playerInput = new PlayerInput();
        playerInput.playerController.Move.started += OnMove;
        playerInput.playerController.Move.performed += OnMove;
        playerInput.playerController.Move.canceled += OnMove;

        rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {

    }

    void Update()
    {
        Debug.Log(movementInput);

        rb.velocity = movement;
    }

    private void OnMove(InputAction.CallbackContext callback)
    {
        movementInput = callback.ReadValue<Vector2>();
        movement = movementInput * moveSpeed;
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
