using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    private bool trigger = false;
    public Vector3 vec = new Vector3(1, 1, 1);
    public int steps;
    private int i;
    private float t;
    private bool timeTrigger = false;
    public float timeLeft = 2;
    // Start is called before the first frame update
    void Start()
    {
        i = steps;
        vec = vec / i;
        t = timeLeft;
    }
    // Update is called once per frame
    void Update()
    {

        if (timeTrigger)
        {
            t -= Time.deltaTime;
            if (t < 0)
            {
                trigger = false;
                timeTrigger = false;
                t = timeLeft;
            }
        }

        if (trigger && i > 0)
        {
            i--;
            transform.position += vec;
        }
        else if (i < steps && !trigger)
        {
            i++;
            transform.position -= vec;
        }
        else if (i==0)
        {
            timeTrigger = true;
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        
        if (other.gameObject.tag.Contains("Player") && other.transform.position.y > gameObject.transform.position.y)
        {
            trigger = true;
        }
    }



}
