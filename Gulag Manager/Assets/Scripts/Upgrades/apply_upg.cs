using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

public class apply_upg : MonoBehaviour
{

    public Upgrade ap_upg; 
    public Estrutura ap_struct;
    


    public void Aplly_upg()
    {

        Debug.Log(ap_struct.nome);
        for(int i = 0; i<(ap_upg.atrib_effects.Length);i++)
        {
            if (i%2==0)
            {

                string new_value = (string)ap_struct.GetType().GetField(ap_upg.atrib_effects[i]).GetValue(ap_struct);
                Debug.Log("+--------------------Prop Antiga: " + new_value);
                new_value += ap_upg.atrib_effects[i+1];
                Debug.Log("+-------------------Prop Nova Teorica: " + new_value);
                
                ap_struct.GetType().GetField(ap_upg.atrib_effects[i]).SetValue(ap_struct, new_value);
                Debug.Log("+--------------------Prop Nova Real: " + ap_struct.nome);
            }
            
        }

        Debug.Log(ap_struct.nome);


    }



}





