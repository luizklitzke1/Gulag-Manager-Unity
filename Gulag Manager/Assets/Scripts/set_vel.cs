using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class set_vel : MonoBehaviour
{

    public float new_vel;
    public static Calendario Calendario;

    public GameObject highlight_outline;

    public GameObject[] outlines;



    // Start is called before the first frame update
    void Start()
    {

        GameObject outline0 = GameObject.Find("select_0x");
        GameObject outline1 = GameObject.Find("select_1x");
        GameObject outline2 = GameObject.Find("select_2x");
        GameObject outline5 = GameObject.Find("select_5x");

        outlines = new GameObject[] {outline0,outline1,outline2,outline5};

        GameObject calendario = GameObject.Find("Calendario");

        Calendario script_calend = calendario.GetComponent<Calendario>();

        Calendario = script_calend;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Set_Vel()
    {

        for (int i = 0;i<4;i++)
        {
            //outlines[i].SetActive(false);
        }

        //highlight_outline.SetActive(true);

        if (new_vel != 0)
        {
            Calendario.vel = Calendario.vel_base/new_vel;
        }
        else
        {
            Calendario.vel = 0;
        }
        

    }

}
