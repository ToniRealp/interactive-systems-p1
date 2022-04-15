using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed = 0;
    
    private Rigidbody _rigidbody;
    private Vector3 _movement;
    private Animator _animator;
    private static readonly int XMovement = Animator.StringToHash("XMovement");
    private static readonly int YMovement = Animator.StringToHash("YMovement");

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _animator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        gameObject.transform.position += _movement * Time.deltaTime * speed;
    }
    
    void OnMove(InputValue inputValue)
    {
        Vector2 movementVector = inputValue.Get<Vector2>();
        _movement.Set(movementVector.x,0, movementVector.y);
        _animator.SetFloat(XMovement,movementVector.x);
        _animator.SetFloat(YMovement,movementVector.y);
        Debug.Log(movementVector.y);
    }
}
