using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;
        
        Destroy(this.gameObject);
        EventManager.OnPickUp.Invoke();
    }
}
