using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class backbutton : MonoBehaviour {

    public GameObject other_menu;
   
    // Update is called once per frame
    void Update () {
        // Reverse the active state every time escape is pressed
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Check whether it's active / inactive
            bool isActive = other_menu.activeSelf;
 
            other_menu.SetActive(!isActive);
        }
    }
}