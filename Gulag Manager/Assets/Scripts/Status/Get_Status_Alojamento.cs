using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Get_Status_Alojamento : MonoBehaviour
{

    public est_aloj aloj;

    public TextMeshProUGUI nivel;
    public TextMeshProUGUI estado;

    public TextMeshProUGUI alocados;

    // Start is called before the first frame update
    void Start()
    {
       nivel.SetText(Convert.ToString(aloj.level));
       estado.SetText(Convert.ToString(aloj.estado));
       alocados.SetText(Convert.ToString(aloj.alocados));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
