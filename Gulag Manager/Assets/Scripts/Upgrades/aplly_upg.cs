using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aplly_upg : MonoBehaviour
{

    public Upgrade _upg; 
    public Estrutura _struct;
    


    public void Aplly_upg()
    {

        /*foreach (object effect in _upg.effects_list)
        {
            struct.GetType().GetProperty(effect[0]).SetValue(struct, effect[1]);
        }
       
        */

         _struct.GetType().GetProperty("carlos").SetValue(_struct, 43);

    }



}




