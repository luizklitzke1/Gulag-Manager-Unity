using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class est_animator : MonoBehaviour
{
        public Animator aloj_Animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (est_aloj.Alojamento.level == 1)
        {
            aloj_Animator.SetInteger("alojLvl", 1);
        }
        else if (est_aloj.Alojamento.level == 2)
        {
            aloj_Animator.SetInteger("alojLvl", 2);
        }

    }
}
