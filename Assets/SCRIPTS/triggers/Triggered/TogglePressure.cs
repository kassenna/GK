using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Katarzyna Majgier

public class TogglePressure : MonoBehaviour
{
    
    public Vector3 movePosition;
    public float velocity;
    public int time;
    public int _i;

    public bool _toggle = false;
    private Rigidbody _rb;
    
    private bool _pressure=false;
    void Start()
    {
        time =  (int)(movePosition.magnitude/velocity);
        movePosition = movePosition / time;
        _i = 1;
        _rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (_pressure)
        {
            if (_toggle && _i>0 )
            {
                Debug.Log("+++");
                _i--;
                _rb.MovePosition(transform.position + movePosition);
            }
            else if(!_toggle && _i < time)
            {
                Debug.Log("---");
                _i++;
                _rb.MovePosition(transform.position - movePosition);
            } 
            if(_i==0 || _i==time)
            _toggle = !_toggle;
        }
    }

   
    public void  trigger(bool isCollide)
    {
        _pressure = isCollide;
       if (isCollide){
           _rb.constraints = RigidbodyConstraints.FreezeRotation;
        }
        else
       {
         
           _rb.constraints = 0;
       }
    }
}
