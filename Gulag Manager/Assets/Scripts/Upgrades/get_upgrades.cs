﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class get_upgrades : MonoBehaviour
{

    public ControladorGame controladorGame;
    public string setor;

    private string str_titulo;
    private Color32 clr_titulo;


    public TextMeshProUGUI titulo;

    public List<Upgrade> lista_esp;

    public List<Upg_info> lista_upgs_info;
    public List<GameObject> objects_upg_info;

    string lista;
    string est;



    // Start is called before the first frame update
    void Start()
    {

        switch (setor)
        {
            case "recur":
                str_titulo = "Recursos";
                clr_titulo = new Color32(0,255,0,255);
                break;

            case "medic":
                str_titulo = "Médico";
                clr_titulo = new Color32(0,255,0,255);
                break;

            case "aloj":
                str_titulo = "Alojamento";
                clr_titulo = new Color32(255,255,255,255);
                break;

            case "segur":
                str_titulo = "Segurança";
                clr_titulo = new Color32(255,0,0,255);
                break;
            

        }

            
        

        titulo.SetText(str_titulo);
        titulo.color = clr_titulo;

        foreach (GameObject Gobj in objects_upg_info)
        {
            Gobj.SetActive(true);
        }

        lista = setor + "_upgs";
        est = "Est_"+ setor;


        Get_Current();



    }
    // Update is called once per frame
    void Update()
    {

        Get_Current();

    }

    //Atualiza os upgrades atualmente mostrados na tela
    void Get_Current()
    {

        lista_esp  = (List<Upgrade>)controladorGame.GetType().GetField(lista).GetValue(controladorGame);

        Estrutura estrutura = (Estrutura)controladorGame.GetType().GetField(est).GetValue(controladorGame);

        Debug.Log(lista_esp.Count);

        for (int i=0; i<4 ;i ++)
        {

            if (i < (lista_esp.Count))
            {
                Upgrade upgrade = lista_esp[i];
                //Debug.Log(upgrade.nome+upgrade.desc);
                //Debug.Log(estrutura.nome);

                lista_upgs_info[i].Set_Value(upgrade.nome,upgrade.desc, upgrade.effects_txt_list,upgrade,estrutura,lista);
            }

            else
            {
                objects_upg_info[i].SetActive(false);
            }
                

        }
    }

}
