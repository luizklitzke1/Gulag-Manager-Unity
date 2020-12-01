using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Get_Status_Seguranca : MonoBehaviour
{

    public est_segur segur;

    public TextMeshProUGUI nivel;
    public TextMeshProUGUI estado;

    public TextMeshProUGUI alocados;
    public TextMeshProUGUI arm;
    public TextMeshProUGUI intimi;
    public TextMeshProUGUI prison;

    // Start is called before the first frame update
    void Start()
    {
       nivel.SetText(Convert.ToString(segur.level));
       estado.SetText(Convert.ToString(segur.estado));

       alocados.SetText(Convert.ToString(segur.alocados));
       arm.SetText(Convert.ToString(segur.arm));
       intimi.SetText(Convert.ToString(segur.intimi));
       prison.SetText(Convert.ToString(segur.prison));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
