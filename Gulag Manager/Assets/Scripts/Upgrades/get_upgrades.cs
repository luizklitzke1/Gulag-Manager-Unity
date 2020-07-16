﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class get_upgrades : MonoBehaviour
{

    public ControladorGame controladorGame;
    public string setor;

    public Upg_info upg_info1;
    //public Upgrade upg1;

    public Upg_info upg_info2;
    //public Upgrade upg2;

    public Upg_info upg_info3;
    //public Upgrade upg3;

    public Upg_info upg_info4;
    //public Upgrade upg4;


    public List<Upgrade> lista_esp;
    public Upg_info[] lista_upgs_info;



    // Start is called before the first frame update
    void Start()
    {

        string lista = setor + "_upgs";
        //Debug.Log(lista);
        string est = "Est_"+ setor;
        //Debug.Log(est);

        //upg1 = (ControladorGame.GetProperty(lista))[0];
        //Upgrade upg1 = (Upgrade[])ControladorGame.GetType().GetField(lista).GetValue(ControladorGame);


        //Upg_info[] lista_upgs_info =  {upg_info1,upg_info2,upg_info3,upg_info4};

        lista_esp  = (List<Upgrade>)controladorGame.GetType().GetField(lista).GetValue(controladorGame);

        Estrutura estrutura = (Estrutura)controladorGame.GetType().GetField(est).GetValue(controladorGame);


        for (int i=0; i<4;i ++){

            Upgrade upgrade = lista_esp[i];
            //Debug.Log(upgrade.nome+upgrade.desc);
            //Debug.Log(estrutura.nome);

            lista_upgs_info[i].Set_Value(upgrade.nome,upgrade.desc, upgrade.effects_txt_list,upgrade,estrutura);
            


        }


        //this.GetType().GetProperty("newVar").SetValue(this, 38);



        //upg_info[] lista_esp = {script1,script2,script3,script4};


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
