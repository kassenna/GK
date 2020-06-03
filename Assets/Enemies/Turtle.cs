using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using Random = UnityEngine.Random;

public class Turtle : MonoBehaviour
{
    private Rigidbody rb;
    public float velocity = 1;
    void Start()
    {
         rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        rb.MovePosition(transform.position + (transform.forward) * (Time.deltaTime * velocity));
    }

        
    
}
