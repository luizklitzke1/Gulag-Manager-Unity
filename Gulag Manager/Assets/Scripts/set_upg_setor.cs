using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class set_upg_setor : MonoBehaviour
{

    public get_upgrades upgs_esp;
    public GameObject obj_upgs;
    public string _setor;


    public void Set_setor()
    {
        upgs_esp.setor = _setor;
        obj_upgs.SetActive(true);
        upgs_esp.Reset();
    }

}
