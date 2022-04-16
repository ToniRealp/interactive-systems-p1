using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public static class EventManager
{
    public static readonly UnityEvent OnPickUp = new UnityEvent();
    public static readonly UnityEvent OnWin = new UnityEvent();
    public static readonly UnityEvent OnReset = new UnityEvent();
}
