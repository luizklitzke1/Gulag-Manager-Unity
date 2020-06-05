using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class est_med : Estrutura
{

    public int doentes;
    public float chance_morte = 0.5f;
    public int leitos = 5;
    public int vel_atend;

    public static est_med Medico;

    // Start is called before the first frame update
    void Start()
    {

        GameObject Estrutura_Medico = GameObject.Find("Medico");

        est_med script_med = Estrutura_Medico.GetComponent<est_med>();

        Medico = script_med;



    }


    // Update is called once per frame
    void Update()
    {
        if (Medico.level == 2)
        {
            animator.SetInteger("medicoLvl", 2);
        }
    }
}
