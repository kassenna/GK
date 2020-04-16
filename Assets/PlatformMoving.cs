using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMoving : MonoBehaviour
{
    private bool dir = true;
    public Vector3 direction;
    public int steps;
    public int i;
    private Rigidbody rb;
    private void Start()
    {
        i = 0;
    }

    void Update()
    {

        rb = GetComponent<Rigidbody>();
        if (dir)
        {
            rb.MovePosition(transform.position + (direction) * Time.fixedDeltaTime);
            i++;
            if (i == steps) dir = false;
        }
        else
        {
            rb.MovePosition(transform.position - (direction) * Time.fixedDeltaTime);
            i--;
            if (i == 0) dir = true;
        }

    }

}