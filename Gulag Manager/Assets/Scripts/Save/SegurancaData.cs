using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class SegurancaData 
{
    public int segur_arm = 1;
    public int segur_intimi = 1;
    public int segur_prison;

    public SegurancaData(est_segur estSegur) {

        segur_arm = estSegur.arm;
        segur_intimi = estSegur.intimi;
        segur_prison = estSegur.prison;
        
    } 
}
