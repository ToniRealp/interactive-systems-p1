using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 0;
    
    private Rigidbody _rigidbody;
    private Vector3 _movement;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        _rigidbody.AddForce(_movement*speed);
    }
    
    void OnMove(InputValue inputValue)
    {
        Vector2 movementVector = inputValue.Get<Vector2>();
        _movement.Set(movementVector.x,0, movementVector.y);

    }
}
