using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
// Katarzyna Majgier

public class ResetChildren : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(true);
        }
        
    }
}
