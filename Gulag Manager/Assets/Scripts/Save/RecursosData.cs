using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class RecursosData 
{
    public int recur_estoque;
    public int recur_vel_estraxt;
    public int recur_total_injur;
    public float recur_risc_injur;

    public RecursosData(est_recur estRecur) { 

        recur_estoque = estRecur.estoque;
        recur_vel_estraxt = estRecur.vel_estraxt;
        recur_total_injur = estRecur.total_injur;
        recur_risc_injur= estRecur.risc_injur;

    }
}
