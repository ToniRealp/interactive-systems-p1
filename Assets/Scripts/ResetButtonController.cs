using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class ResetButtonController : MonoBehaviour
{
    private void Start()
    {
        gameObject.SetActive(false);
        EventManager.OnWin.AddListener(()=>{gameObject.SetActive(true);});
        EventManager.OnReset.AddListener(() => {gameObject.SetActive(false);});

    }

    private void OnDestroy()
    {
        EventManager.OnWin.RemoveListener(() => { gameObject.SetActive(true); });
        EventManager.OnReset.RemoveListener(() => { gameObject.SetActive(false); });
    }
}
