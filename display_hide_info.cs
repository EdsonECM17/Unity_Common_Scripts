using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class display_hide_info : MonoBehaviour
{
    public GameObject information;
    void OnMouseOver()
    {
        //If mouse hovers over the GameObject with the script attached, information object is activated
        information.SetActive(true);
    }

    void OnMouseExit()
    {
        //If mouse is no longer hovering over the GameObject, information object is disabled
        information.SetActive(false);
    }
}
