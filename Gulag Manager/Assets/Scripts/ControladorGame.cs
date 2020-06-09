using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ControladorGame : MonoBehaviour
{

    public static Gulag gulag_game = Controlador.gulag_atual;

    public static Upgrade[] struct_upgs = new Upgrade[] {};
    public static Upgrade[] medic_upgs = new Upgrade[] {};
    public static Upgrade[] recur_upgs = new Upgrade[] {};
    public static Upgrade[] segur_upgs = new Upgrade[] {};

    //Upgrades estrutura
    public Upgrade upg_cimento = new Upgrade("Cimento do Scarpelly","Krlo, Scarpelly as 3am fazendo cimento",
                    420.69f,
                    (new object[,] {{"carlos",13},}),
                    (new object[,] {{"+Cimento do Scarpelly",1},})
                    );



    // Start is called before the first frame update
    void Start()
    {

        


    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log(upg_cimento.effects_txt_list[0,0]);


    }

}

public class Upgrade
{
 
    public string nome;
    public string desc;
    public float price;

    public object[,] effects_list;
    public object[,] effects_txt_list;

    public Upgrade(string _nome,string _desc,float _price,  
                    object[,] _effects_list, object[,] _effects_txt_list)
    {
        nome = _nome;
        desc = _desc;
        price = _price;
        effects_list = _effects_list;
        effects_txt_list = _effects_txt_list;
    }

}
