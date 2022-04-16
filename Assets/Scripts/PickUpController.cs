using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;
        gameObject.SetActive(false);
        EventManager.OnPickUp.Invoke();
    }

    private void OnEnable()
    {
        EventManager.OnReset.RemoveListener(()=>{gameObject.SetActive(true);});
    }
    
    private void OnDisable()
    {
        EventManager.OnReset.AddListener(() =>
        {
            gameObject.SetActive(true);
        });
    }

}
