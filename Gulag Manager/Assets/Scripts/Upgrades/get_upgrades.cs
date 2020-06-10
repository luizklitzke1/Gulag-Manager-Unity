using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class get_upgrades : MonoBehaviour
{

    public string lista;



    public GameObject atual;

    public upgrade_info script1;
    public upgrade_info script2;
    public upgrade_info script3;
    public upgrade_info script4;

    public Upgrade[] lista_upgs;
    public upgrade_info[] lista_esp;




    // Start is called before the first frame update
    void Start()
    {
        GameObject Controle = GameObject.Find("ControladorGame");
        lista_upgs = Controle.GetComponent(lista as Upgrade[]);

        upgrade_info[] lista_esp = { script1, script2, script3, script4 };


        for (int i = 0; i < 4; i++)
        {
            //lista_esp[i].nome_upg.SetText(lista_upgs[0].ToString());
        }


        //for (int i=0; i<4; i++)
        {
            // atual = lista_upgs[i];

            //atual.nome_upg.SetText(atual.nome);
            //atual.desc_upg.SetText(atual.desc);
            //atual.effect_1.SetText(atual.effects_txt_list[0,0]);
            //atual.effect_2.SetText(atual.effects_txt_list[1,0]);

        }


    }

    // Update is called once per frame
    void Update()
    {

    }
}
