using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu (fileName = "Upgrade", menuName = "Upgrade")]
public class Upgrade: ScriptableObject
{

    public string nome;
    public string desc;
    public float price;

    public string[] atrib_effects;

    public string[] effects_txt_list;

}