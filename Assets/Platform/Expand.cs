using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Expand : MonoBehaviour
{
    private bool trigger = true;
    public Vector3 vec = new Vector3(1, 0, 1);
    public int steps;
    private  float widthX;
    private float widthZ;
    public int end=0;
    private int i;
    private float t;
    public float timeLeft = 2;
    // Start is called before the first frame update
    void Start()
    {
        widthX = gameObject.transform.localScale.x;
        widthZ = gameObject.transform.localScale.z;
        i = steps;
        vec = new Vector3(widthX/(steps-end), 0, widthZ/(steps-end));
    }
    // Update is called once per frame
    void Update()
    {
        t-= Time.deltaTime;
        if ( t < 0 )
        {
            trigger = false;
        }
        if (trigger && i > end)
        {
            i--;
            transform.localScale -= vec;
        }
        if (i < steps && !trigger)
        {
            i++;
            transform.localScale += vec;
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        
        if (other.gameObject.tag.Contains("Player") && other.transform.position.y > gameObject.transform.position.y)
        {
            trigger = true;
            t = timeLeft;
        }
    }

    private void OnCollisionExit(Collision other)
    {
        t = timeLeft;

    }
}

