using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleData
{
    public  List<Upgrade> data_medic_upgs;
    public  List<Upgrade> data_recur_upgs;
    public  List<Upgrade> data_segur_upgs;
    public  List<Upgrade> data_aloj_upgs;

    public ControleData(ControladorGame control) {

    data_medic_upgs = control.medic_upgs;
    data_recur_upgs = control.medic_upgs;
    data_segur_upgs = control.segur_upgs;
    data_aloj_upgs = control.aloj_upgs;

    }

}
