using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basic_navigation : MonoBehaviour
{

    public GameObject obj1;
    public GameObject obj2;


    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown("escape"))
        {
            obj1.SetActive(false);
            obj2.SetActive(true);

        }
    }
}
