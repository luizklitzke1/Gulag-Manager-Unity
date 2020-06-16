using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ControladorGame : MonoBehaviour
{
    public static Gulag gulag_game = Controlador.gulag_atual;

    public static int  myVar = 47;
    
    public  Upgrade[] medic_upgs = new Upgrade[] {};
    public  Upgrade[] recur_upgs = new Upgrade[] {};
    public  Upgrade[] segur_upgs = new Upgrade[] {};

    //Upgrades estrutura
    public static Upgrade upg_cimento = new Upgrade("Cimento do Scarpelly1","1 Krlo, Scarpelly as 3am fazendo cimento",
                    420.69f,
                    (new object[,] {{"carlos",13},}),
                    (new object[,] {{"+ Cimento do Scarpelly2",1},{" ",0}})
                    );
    public static Upgrade upg_cimento2 = new Upgrade("Nego diz que bomba mata","Pobre tem mais é que tomar bomba porra!",
                    420.69f,
                    (new object[,] {{"carlos",13},}),
                    (new object[,] {{"- Dinheiro por causa da bomba",0},
                                    {"+ Pobre bombado",1}})
                    );
    public static Upgrade upg_cimento3 = new Upgrade("Cimento do Scarpelly3","3  Krlo, Scarpelly as 3am fazendo cimento",
                    420.69f,
                    (new object[,] {{"carlos",13},}),
                    (new object[,] {{"+ Cimento do Scarpelly",1},
                    {"+ Pobre bombado",1}})
                    );
    public static Upgrade upg_cimento4 = new Upgrade("Cachorro do Scarpelly4","Buldog filho da puta",
    420.69f,
                    (new object[,] {{"carlos",13},}),
                    (new object[,] {{"- Cachorro destroi os bang",1},
                                    {"+ Cachorro no vídeo",0}})
                    );



    public static Upgrade[] struct_upgs = new Upgrade[] { upg_cimento, upg_cimento2, upg_cimento3, upg_cimento4 };




    // Start is called before the first frame update
    void Start()
    {




    }

    // Update is called once per frame
    void Update()
    {


    }

}

public class Upgrade
{

    public string nome;
    public string desc;
    public float price;

    public object[,] effects_list;
    public object[,] effects_txt_list;

    public Upgrade(string _nome, string _desc, float _price,
                    object[,] _effects_list, object[,] _effects_txt_list)
    {
        nome = _nome;
        desc = _desc;
        price = _price;
        effects_list = _effects_list;
        effects_txt_list = _effects_txt_list;
    }

}
