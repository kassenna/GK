using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Expand : MonoBehaviour
{
    private bool _trigger = true;
    public Vector3 vec = new Vector3(1, 0, 1);
    public int steps;
   
    public int end=0;
    private int _i;
    private float _t;
    public float timeLeft = 2;
    
    // Start is called before the first frame update
    void Start()
    {
       float widthX;
       float widthZ;
       var localScale = gameObject.transform.localScale;
       widthX = localScale.x;
        widthZ = localScale.z;
        _i = steps;
        vec = new Vector3(widthX/(steps-end), 0, widthZ/(steps-end));
    }
    // Update is called once per frame
    void Update()
    {
        _t-= Time.deltaTime;
        if ( _t < 0 )
        {
            _trigger = false;
        }
        else if (_trigger && _i > end)
        {
            _i--;
            transform.localScale -= vec;
        }
        else if (_i < steps && !_trigger)
        {
            _i++;
            transform.localScale += vec;
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag.Contains("Player") && other.transform.position.y > gameObject.transform.position.y)
        {
            _trigger = true;
            _t = timeLeft;
        }
    }

    private void OnCollisionExit(Collision other)
    {
        _t = timeLeft;
    }
}

