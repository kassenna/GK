using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using Random = UnityEngine.Random;

public class Turtle : MonoBehaviour
{

    private float xm;
    private float zm;
    public float velocity = 1;
    void Start()
    {
        transform.localPosition = new Vector3(0f, 3, 0f);
        xm = transform.parent.lossyScale.x * 0.45f;
        zm = transform.parent.localScale.z * 0.45f;
    }

    void Update()
    {
       
          var rb = GetComponent<Rigidbody>();
          if (Mathf.Abs(transform.localPosition.x) <= xm && Mathf.Abs(transform.localPosition.z) <= zm)
            rb.MovePosition(transform.position + (transform.forward) * (Time.deltaTime * velocity));
        else{
            transform.Rotate(Vector3.up * -90, Space.Self);
            rb.MovePosition(transform.position + (transform.forward) * (Time.deltaTime * velocity));
                      
        }

        
    }
}
