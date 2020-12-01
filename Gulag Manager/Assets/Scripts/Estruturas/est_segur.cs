using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class est_segur : Estrutura
{

    public int arm = 1;
    public int intimi = 1;
    public int prison;
    public static est_segur Seguranca;

    // Start is called before the first frame update
    void Start()
    {

        GameObject Estrutura_Seguranca = GameObject.Find("Seguranca");

        est_segur script_segur = Estrutura_Seguranca.GetComponent<est_segur>();

        Seguranca = script_segur;

    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
