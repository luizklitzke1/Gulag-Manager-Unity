using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class get_upgrades : MonoBehaviour
{

    public string lista;

    public Upgrade[] lista_upgs = ControladorGame.struct_upgs;

    public GameObject atual;

    public  upgrade_info script1;
    public  upgrade_info script2;
    public  upgrade_info script3;
    public  upgrade_info script4;


    public upgrade_info[] lista_esp;

    


    // Start is called before the first frame update
    void Start()
    {

        GameObject upg1 = GameObject.Find("Upgrade-Info1");
        script1 = upg1.GetComponent<upgrade_info>();

        GameObject upg2 = GameObject.Find("Upgrade-Info2");
        script2 = upg2.GetComponent<upgrade_info>();

        GameObject upg3 = GameObject.Find("Upgrade-Info3");
        script3 = upg3.GetComponent<upgrade_info>();

        GameObject upg4 = GameObject.Find("Upgrade-Info4");
        script4 = upg4.GetComponent<upgrade_info>();

        upgrade_info[] lista_esp = {script1,script2,script3,script4};


        for (int i =0; i<4;i++)
        {
            lista_esp[i].nome_upg.SetText("CArlito");
        }


        //for (int i=0; i<4; i++)
        {
           // atual = lista_esp[i];
            
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
