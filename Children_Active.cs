using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class Children_Active : MonoBehaviour
{
    public GameObject parent;
    public UnityEvent general_event;

    // Function to check if all children of a parent gameobject are active 
    public void all_children_active()
    {
        // boolean indicating an initial state of the script (suppose all children are active)
        bool all_active = true;
        // for to explore each chidren of the parent object one by one
        for (int i = 0; i < parent.transform.childCount; i++)
        {
            // If i object is not active, chance "all_active" boolean to false
            if (!parent.transform.GetChild(i).gameObject.activeInHierarchy)
            {
                all_active = false;
            }
        }
        // if "all_active" boolean is still true, generate an event (specified in Unity interfase)
        if (all_active == true)
        {
            general_event.Invoke();
        }
            
    }
}
