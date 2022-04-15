using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WinTextController : MonoBehaviour
{

    private TextMeshProUGUI winText;

    private void Start()
    {
        winText = gameObject.GetComponent<TextMeshProUGUI>();
        winText.enabled = false;
    }

    private void OnEnable()
    {
        EventManager.OnWin.AddListener(ShowWinMessage);
    }

    private void OnDisable()
    {
        EventManager.OnWin.RemoveListener(ShowWinMessage);
    }

    private void ShowWinMessage()
    {
        winText.enabled = true;
        Debug.Log("hello there");
    }
}
