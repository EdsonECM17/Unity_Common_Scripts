using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class display_object_info : MonoBehaviour
{
    // This script shows information of a gameobject once mouse hovers over the gameobject
    public GameObject information;
    void OnMouseOver()
    {
        information.SetActive(true);
    }
}