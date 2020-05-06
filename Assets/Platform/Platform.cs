using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{

public Vector3 direction;
public bool isTouch =false;
public int steps;
public int i;
private Rigidbody rb;
private void Start()
{
    i = 0;
}

void Update()
{

        if (!isTouch && i > 0)
        {
            rb = GetComponent<Rigidbody>();
            rb.MovePosition(transform.position - (direction) * Time.fixedDeltaTime);
            i--;
        }
    
}

private void OnCollisionStay(Collision other)
{
    if (i < steps)
    {
        rb = GetComponent<Rigidbody>();
        rb.MovePosition(transform.position + (direction) * Time.fixedDeltaTime);
        i++;
    }

    isTouch = true;
}
}
