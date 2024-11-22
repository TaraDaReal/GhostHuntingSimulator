using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMoveForwardOnly : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 5f;

    private Vector2 moveInput;
    private Rigidbody2D rb;

    private void Awake() 
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void OnMovement(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        Vector2 moveDirection = moveInput.normalized;
        rb.velocity = moveDirection * _moveSpeed;
    }
}
