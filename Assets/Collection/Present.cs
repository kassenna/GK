using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Present : MonoBehaviour
{
   
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (PlayerState.big)
            {
                PlayerState.hat = true;
            }
            else
            {
                PlayerState.big = true;
                other.transform.localScale += new Vector3(0, 0.15f, 0);
            }
            Destroy(gameObject);
        }
    }
}
