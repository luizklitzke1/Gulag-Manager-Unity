using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class est_aloj : Estrutura
{

    public static est_aloj Alojamento;

    // Start is called before the first frame update
    void Start()
    {

        GameObject Estrutura_Alojamento = GameObject.Find("Alojamento");

        est_aloj script_aloj = Estrutura_Alojamento.GetComponent<est_aloj>();

        Alojamento = script_aloj;

    }

    // Update is called once per frame
    void Update()
    {

    }
}
