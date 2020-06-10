using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TogglePressure : MonoBehaviour
{
    
    public Vector3 movePosition;
    public float velocity;
    public int time;
    private int _i;

    private bool _toggle = false;
    private Rigidbody _rb;
    
    private bool _pressure=false;
    void Start()
    {
        time =  (int)(movePosition.magnitude/velocity);
        movePosition = movePosition / time;
        _i = 0;
        _rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (_pressure)
        {
            if (_toggle && _i>0 )
            {
                _i--;
                _rb.MovePosition(transform.position + movePosition);
            }
            else if(!_toggle && _i < time)
            {
                _i++;
                _rb.MovePosition(transform.position - movePosition);
            } 
        }
    }

   
    public void  trigger(bool isCollide)
    {
        _pressure = isCollide;
       if (isCollide)
        {
            _toggle = !_toggle;
            _rb.constraints = RigidbodyConstraints.FreezeRotation;
        }
        else
       {
           _rb.constraints = 0;
       }
    }
}
