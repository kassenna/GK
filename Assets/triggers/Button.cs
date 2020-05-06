using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public Color color;
    private Renderer ren;
    public Vector3 transform;
    public int steps;
    public int velocity;
    private bool toggle = true;
    public int i;
    private Rigidbody rb;
    public GameObject gameObjects;
    void Start()
    {
        steps = velocity * (int)transform.magnitude;
        ren = GetComponent<Renderer>();
        ren.material.SetColor("_Color", color);
        var ren2 = gameObject.GetComponent<Renderer>();
        ren2.material.SetColor("_Color", color);
        transform = transform / steps;
        i = 0;
    }


    private void OnTriggerStay(Collider other)
    {
        if (toggle && i>0 )
        {
            i--;
            rb = gameObjects.GetComponent<Rigidbody>();
            rb.MovePosition(rb.position + transform);
        }
        else if(!toggle && i < steps)
        {
            i++;
            rb = gameObjects.GetComponent<Rigidbody>();
            rb.MovePosition(rb.position - transform);
            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
           
        rb = gameObjects.GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezeRotation;
      

    }

    private void OnTriggerExit(Collider other)
    {
        rb = gameObjects.GetComponent<Rigidbody>();
        rb.constraints = 0;
        toggle = !toggle;
    }
}
