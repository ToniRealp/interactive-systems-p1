using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    private void OnEnable()
    {
        EventManager.OnPickUp.AddListener(UpdateSceneState);
    }

    private void OnDisable()
    {
        EventManager.OnPickUp.RemoveListener(UpdateSceneState);
    }

    private void UpdateSceneState()
    {
        if (GameObject.FindGameObjectsWithTag("PickUp").Length <= 0)
        {
            EventManager.OnWin.Invoke();
        }  
    }

    public void ResetGame()
    {
        EventManager.OnReset.Invoke();
    }
}
