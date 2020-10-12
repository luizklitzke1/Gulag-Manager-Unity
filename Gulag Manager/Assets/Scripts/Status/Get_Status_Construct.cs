using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Get_Status_Construct : MonoBehaviour
{
    public est_aloj scr;

    public TextMeshProUGUI nivel;
    public TextMeshProUGUI estado;

    public TextMeshProUGUI alocados;
    public TextMeshProUGUI nome;


    // Start is called before the first frame update
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        nivel.SetText(Convert.ToString(scr.level));
        estado.SetText(Convert.ToString(scr.estado));

        alocados.SetText(Convert.ToString(scr.alocados));

        nome.SetText(Convert.ToString(scr.nome));
    }
}
