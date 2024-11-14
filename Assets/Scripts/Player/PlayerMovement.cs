using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 5f;

    private Vector2 _movement;

    private Rigidbody2D _rigidbody;

    private void Awake()
    {

        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        _movement.Set(InputManager.movement.x, InputManager.movement.y);

        _rigidbody.velocity = _movement * _moveSpeed;
    }
}
