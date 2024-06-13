using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LevelManager : MonoBehaviour
{

    public delegate void LevelChange();
    public static event LevelChange levelChange;

    // Boolean to track level change
    private bool isLevelChanged = false;

    private void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.K))
        {
            ChangeLevel();
        }
    }

    void ChangeLevel()
    {
        levelChange?.Invoke();

        isLevelChanged = true;
    }

    // Example method to check if level has changed
    public bool IsLevelChanged()
    {
        return isLevelChanged;
    }

    private void OnDisable()
    {
        // Optional: Reset any necessary states when disabled
        isLevelChanged = false;
    }
}
