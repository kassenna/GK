using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Katarzyna Majgier
public class IceMelt : MonoBehaviour
{
    private Vector3 vec;
    public int steps =10;
    public int end=0;
     
    void Start()
    {
        float widthY  = transform.localScale.y;
        vec = new Vector3(0, widthY/(steps-end), 0);
    }

    private void OnCollisionStay(Collision other)
    {

        if (other.gameObject.tag.Contains("Player"))
        {
            if(steps > 0)
            transform.localScale -= (vec);
            if(steps ==0)
               transform.gameObject.SetActive(false);
            steps--;

        }
    }
}
