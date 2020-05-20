using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TogglePresure : MonoBehaviour
{
    
    public Vector3 movePosition;
    public int velocity;
    private int _steps;
    private int _i;

    private bool _toggle = true;
    private Rigidbody _rb;
    
    private bool _pressure=false;
    void Start()
    {
        _steps = velocity * (int)movePosition.magnitude;
        movePosition = movePosition / _steps;
        _i = 0;
    }

    private void Update()
    {
        if (_pressure)
        {
            if (_toggle && _i>0 )
            {
                _i--;
                _rb = GetComponent<Rigidbody>();
                _rb.MovePosition(_rb.position + movePosition);
            }
            else if(!_toggle && _i < _steps)
            {
                _i++;
                _rb =GetComponent<Rigidbody>();
                _rb.MovePosition(_rb.position - movePosition);
            } 
        }
    }

   
    void trigger(bool isCollide)
    {
        _pressure = isCollide;
        _rb = GetComponent<Rigidbody>();
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
