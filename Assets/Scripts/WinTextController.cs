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
        EventManager.OnReset.AddListener(() => { winText.enabled = false;});
    }

    private void OnDisable()
    {
        EventManager.OnWin.RemoveListener(ShowWinMessage);
        EventManager.OnReset.RemoveListener(() => { winText.enabled = false;});
    }

    private void ShowWinMessage()
    {
        winText.enabled = true;
    }
}
