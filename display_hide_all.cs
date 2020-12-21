using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class display_hide_all : MonoBehaviour
{
    public GameObject parent;
    public string information_ob_name;

    void OnMouseOver()
    {
        // If mouse hovers over the GameObject with the script attached, information object is activated
        // All other objects from the same parent are deactivated
        for (int i = 0; i < parent.transform.childCount; i++)
        {
            // If i object is not active, chance "all_active" boolean to false
            if (parent.transform.GetChild(i).transform.name == information_ob_name)
            {
                parent.transform.GetChild(i).gameObject.SetActive(true);
            }
            else
            {
                parent.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
    }
}
