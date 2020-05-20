using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjectTriggerCollision : MonoBehaviour
{
    private bool _trigger = false;
    public Vector3 vec = new Vector3(1, 1, 1);
   
    private int _steps;
    private int i;
    public float velocity  =0.1f;
    private float t;
    
    private bool _timeTrigger = false;
    public float timeLeft = 2;
    
    void Start()
    {
        _steps = (int) (((vec - transform.position).magnitude)/velocity);
        i = _steps;
        vec = vec / i;
        t = timeLeft;
    }
    
    void Update()
    {
        if (_trigger)
        {
            if(i>0){ 
                i--;
                transform.position += vec;
            }
        }
        else
        {
            if (_timeTrigger)
            {  t -= Time.deltaTime;
                if (t < 0)
                    _timeTrigger = false;
            }else if (i < _steps)
            {
                i++;
                transform.position -= vec;
            }
        }
    }

 

    private void OnCollisionEnter(Collision other)
    {
        
        if (other.gameObject.tag.Contains("Player") && other.transform.position.y > gameObject.transform.position.y)
        {
            _trigger = true;
            other.transform.parent = transform;
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag.Contains("Player") && other.transform.position.y > gameObject.transform.position.y)
        {
            _timeTrigger = true;
            _trigger =false;
            t = timeLeft;
            other.transform.parent = null;
        }
    }
}
