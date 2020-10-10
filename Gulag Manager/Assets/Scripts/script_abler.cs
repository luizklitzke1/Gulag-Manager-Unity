using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_abler : MonoBehaviour
{
    public MonoBehaviour script;

    public string button;

    public void unable_script (){
        script.enabled = false;
    }

    public void able_script (){
        script.enabled = true;
    }

    /*
    // Update is called once per frame
    void Update()
    {
        if (button != ""){
            if (Input.GetKeyDown(button))
            {
                script.enabled = true;

            }
        }
    }
    */

}


