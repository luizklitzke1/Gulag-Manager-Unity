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

    public TextMeshProUGUI pricetxt;

    public GameObject btn_comprar;

    //Definir os valores dos upgrades
    public void Set_Value(Upgrade _upg, Estrutura _struct,
                          string _lista)
    {
        nome_upg.SetText(_upg.nome);
        desc_upg.SetText(_upg.desc);
        pricetxt.SetText(Convert.ToString(_upg.price));

        //upgrade._upg.effects_txt_list[1,0].ToString(),Convert.ToInt32(upgrade._upg.effects_txt_list[1,1]


        effect_1.SetText(_upg.effects_txt_list[0]);
        if (Convert.ToInt32(_upg.effects_txt_list[1]) == 1){
            effect_1.color = new Color32(26, 118, 26, 255);
        }
        else{
            effect_1.color = new Color32(255, 0, 0, 255);
        }

        effect_2.SetText(_upg.effects_txt_list[2]);
        if (Convert.ToInt32(_upg.effects_txt_list[3]) == 1){
            effect_2.color = new Color32(26, 118, 26, 255);
        }
        else{
            effect_2.color = new Color32(255, 0, 0, 255);
        }

        btn_comprar.GetComponent<apply_upg>().ap_upg = _upg;
        
        btn_comprar.GetComponent<apply_upg>().ap_struct = _struct;

        btn_comprar.GetComponent<apply_upg>().lista = _lista;

    }
}
