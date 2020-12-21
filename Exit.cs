using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
    // Run to close unity application
    public void exit_game()
    {
        Debug.Log("Exit button has been pressed");
        Application.Quit();
    }

}
