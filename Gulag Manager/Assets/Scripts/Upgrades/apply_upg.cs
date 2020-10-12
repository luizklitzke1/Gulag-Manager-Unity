﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class apply_upg : MonoBehaviour
{

    public Upgrade ap_upg; 
    public Estrutura ap_struct;
    public string lista;

    public ControladorGame controladorGame;
    public get_upgrades get_upgs; 


    public void Apply_upg()
    {

        Debug.Log(ap_struct.nome);
    

        for(int i = 0; i<(ap_upg.atrib_effects.Length);i++)
        {
    
            if (i%2==0)
            {

                int new_value = (int)ap_struct.GetType().GetField(ap_upg.atrib_effects[i]).GetValue(ap_struct);
                //Debug.Log("+--------------------Prop Antiga: " + new_value);
                new_value += Convert.ToInt32(ap_upg.atrib_effects[i+1]);
                //Debug.Log("+-------------------Prop Nova Teorica: " + new_value);
                
                ap_struct.GetType().GetField(ap_upg.atrib_effects[i]).SetValue(ap_struct, new_value);
                //Debug.Log("+--------------------Prop Nova Real: " + ap_struct.nome);

            }
            
        }

        //Remover o Upgra da lista geral
        List<Upgrade> upgs = (List<Upgrade>)controladorGame.GetType().GetField(lista).GetValue(controladorGame);
        upgs.Remove(ap_upg);
        get_upgs.Reset();

    }


}





