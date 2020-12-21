using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Change_scene : MonoBehaviour
{
    // Loads a new scene with an specfic user defined name
    public string scene_name;
    
    public void advance()
    {
        SceneManager.LoadScene(scene_name);
    }
}
