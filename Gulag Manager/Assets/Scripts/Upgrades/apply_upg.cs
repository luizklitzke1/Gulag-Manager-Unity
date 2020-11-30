using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class apply_upg : MonoBehaviour
{

    //Upg a ser aplicado
    public Upgrade ap_upg; 

    //Estrutura que sofrera mudança
    public Estrutura ap_struct;
    public string lista;

    //Pop-up de falta de dinheiro
    public GameObject popup;

    public ControladorGame controladorGame;
    public get_upgrades get_upgs; 
    //public List<GameObject> objects_upg_info;



    public void Start(){


    }

    //Aplicar o Upg ao apertar o botão
    public void Apply_upg()
    {

        //Testa se pode ser comprado
        if (ControladorGame.gulag_game.dinheiro >= ap_upg.price){

            Debug.Log("Dinheiro sucifiente!");

            //Tira o preço
            ControladorGame.gulag_game.dinheiro -= ap_upg.price;

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
        //Pop-up de falta de dinheiro
        else{

            Debug.Log("Dinheiro insucifiente!");
            /*
            foreach (GameObject Gobj in objects_upg_info)
            {
                //Debug.Log(Gobj);
                Gobj.SetActive(false);
            }
            */
            popup.SetActive(true);

        }

        //Debug.Log(ap_struct.nome);
    

    }

    //Fecha o pop-up de erro
    public void Close_PopUp(){

        /*
        foreach (GameObject Gobj in objects_upg_info)
        {
            //Debug.Log(Gobj);
            Gobj.SetActive(true);
        }
        */
        popup.SetActive(false);


    }


}





