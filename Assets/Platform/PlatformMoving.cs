using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMoving : MonoBehaviour
{
    public Vector3 direction;
    public float velocity = 0.1f;
    private int _steps=0;
    private int i=0;
    private Rigidbody _rb;

    private void Start()
    {
        _steps = (int) ((direction.magnitude)/velocity);
        direction = direction / _steps;
    }

    void Update()
    {

       
        transform.position += direction ;
         i++;
         if (i == _steps)
        {
            direction = -direction;
            i = 0;
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag.Contains("Player") )
        {
            other.transform.parent = transform;
        }
    }
    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag.Contains("Player") )
        {
            other.transform.parent = null;
        }
    }

}