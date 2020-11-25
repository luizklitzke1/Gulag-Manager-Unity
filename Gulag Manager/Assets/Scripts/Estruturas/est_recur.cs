using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class est_recur : Estrutura
{

    public int estoque;
    public int vel_estraxt = 10;
    public int total_injur = 0;
    public float risc_injur = .2f;

    public static est_recur Recursos;

    // Start is called before the first frame update
    void Start()
    {

        GameObject Estrutura_Recursos = GameObject.Find("Recursos");

        est_recur script_recur = Estrutura_Recursos.GetComponent<est_recur>();

        Recursos = script_recur;

    }

    // Update is called once per frame
    void Update()
    {


        //Lembrar de tirar isso daki posteriormente

        if (ControladorGame.gulag_game.extracao_tipo == "Madeira")
        {
            //animator.SetFloat("tipoExtract", -1);
        }
        else
        {
            //animator.SetFloat("tipoExtract", 1);
        }


    }
}
