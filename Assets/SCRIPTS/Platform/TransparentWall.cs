using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Katarzyna Majgier
public class TransparentWall : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("enemies")){
            other.transform.Rotate(Vector3.up * -90, Space.Self);
        }
    }
    }
