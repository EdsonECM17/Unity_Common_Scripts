using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class On_activation_event : MonoBehaviour
{
    public UnityEvent general_event;
    // Run event when object is activated
    void OnEnable()
    {
        general_event.Invoke();
    }
}