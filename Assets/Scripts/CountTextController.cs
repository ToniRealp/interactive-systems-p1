using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountTextController : MonoBehaviour
{
    public TextMeshProUGUI countText;
    private int _count = 0;
   
    private void Start()
    {
        countText = gameObject.GetComponent<TextMeshProUGUI>();
    }

    private void OnEnable()
    {
        EventManager.OnPickUp.AddListener(UpdateCountText);
    }

    private void OnDisable()
    {
        EventManager.OnPickUp.RemoveListener(UpdateCountText);
    }

    private void UpdateCountText()
    {
        _count += 1;
        countText.text = "Count: " + _count.ToString();
    }
}
