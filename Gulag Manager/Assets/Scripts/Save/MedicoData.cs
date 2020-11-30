using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class MedicoData 
{
    public int med_doentes;
    public float med_chance_morte = 0.5f;
    public int med_leitos = 5;
    public int med_vel_atend;

    public MedicoData(est_med estMed) {

        med_doentes = estMed.doentes;
        med_chance_morte = estMed.chance_morte;
        med_leitos = estMed.leitos;
        med_vel_atend = estMed.vel_atend;

    }
}
