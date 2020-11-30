using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basic_navigation2 : MonoBehaviour
{

    public GameObject obj1;

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown("escape"))
        {
            obj1.SetActive(false);

        }
    }
}
