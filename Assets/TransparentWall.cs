using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransparentWall : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("enemies")){
            other.transform.Rotate(Vector3.up * -90, Space.Self);
        }
    }
    }
