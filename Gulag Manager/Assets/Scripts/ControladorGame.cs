using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ControladorGame : MonoBehaviour
{
    public static Gulag gulag_game = Controlador.gulag_atual;

    public  est_recur Est_recur;
    public  est_med Est_medic;
    public  est_aloj Est_aloj;
    public  est_segur Est_segur;
    
    public  List<Upgrade> medic_upgs;
    public  List<Upgrade> recur_upgs;
    public  List<Upgrade> segur_upgs;
    public  List<Upgrade> aloj_upgs;
    


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    

    }

}


