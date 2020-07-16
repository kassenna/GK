using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using Random = UnityEngine.Random;
// Adam Hudziak

public class Turtle : MonoBehaviour
{
    private Rigidbody rb;
    public float velocity = 1;
    private float time =0;
    
    void Start()
    {
         rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        time -= Time.deltaTime;
        if (time < 0)
        {
            time = Random.Range(2, 6);
            transform.Rotate(Vector3.up * (Random.Range(10, 90) * Time.deltaTime), Space.Self);
        }
        rb.MovePosition(transform.position + (transform.forward) * (Time.deltaTime * velocity));
    }

        
    
}
