using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Upg_info : MonoBehaviour
{
    public TextMeshProUGUI nome_upg;
    public TextMeshProUGUI desc_upg;
    public TextMeshProUGUI effect_1;
    public TextMeshProUGUI effect_2;

    public GameObject btn_comprar;

    //Definir os valores dos upgrades
    public void Set_Value(string nome, string desc, 
                          string[] effects_txt_list,
                          Upgrade _upg, Estrutura _struct,
                          string _lista)
    {
        
        nome_upg.SetText(nome);
        desc_upg.SetText(desc);

        //upgrade.effects_txt_list[1,0].ToString(),Convert.ToInt32(upgrade.effects_txt_list[1,1]


        effect_1.SetText(effects_txt_list[0]);
        if (Convert.ToInt32(effects_txt_list[1]) == 1){
            effect_1.color = new Color32(0, 255, 0, 255);
        }
        else{
            effect_1.color = new Color32(255, 0, 0, 255);
        }

        effect_2.SetText(effects_txt_list[2]);
        if (Convert.ToInt32(effects_txt_list[3]) == 1){
            effect_2.color = new Color32(0, 255, 0, 255);
        }
        else{
            effect_2.color = new Color32(255, 0, 0, 255);
        }

        btn_comprar.GetComponent<apply_upg>().ap_upg = _upg;
        
        btn_comprar.GetComponent<apply_upg>().ap_struct = _struct;

        btn_comprar.GetComponent<apply_upg>().lista = _lista;

    }
}
