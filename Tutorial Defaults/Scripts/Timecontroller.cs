using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timecontroller : MonoBehaviour
{
    private bool paused = false;

    #region Monobehaviour API

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (paused)
                Time.timeScale = 1;
            else
                Time.timeScale = 0;
            paused = !paused;
        }
    }

    #endregion
}
