using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Click_on_object : MonoBehaviour
{
    // Script to check if user click a gameobject of specific name in a scene
    public string gameobject_name;
    public UnityEvent general_event;

    void Update()
    {
        // If a click is detected
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                // If object clicked is the specified one, runs an event
                if (hit.transform.name == gameobject_name)
                {
                    Debug.Log(gameobject_name + " is seleccted");
                    general_event.Invoke();
                }
            }
        }
    }
}
