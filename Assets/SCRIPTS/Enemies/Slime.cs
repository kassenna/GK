using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Katarzyna Majgier
public class Slime : MonoBehaviour
{
   public float velocity = 1;
   private Rigidbody rb;
 
    private void Start()
    { 
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        rb.MovePosition(transform.position + (transform.forward) * (Time.deltaTime * velocity));
    }

 
}