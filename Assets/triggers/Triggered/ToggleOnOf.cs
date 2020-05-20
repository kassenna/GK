using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleOnOf : MonoBehaviour
{

    public new Vector3 transform;
    public int time;
    public int velocity;
   
    private int _i;
    private bool _isTouched = false;
    private bool _toggle = false;
    void Start()
    {
        time = velocity * (int)transform.magnitude;
        _i = time;
        transform = transform / time;
    }

    private void Update()
    {
        if (_isTouched )
        {
            var t = GetComponent<Rigidbody>();
            if (_toggle)
            {
                _i--;
                t.MovePosition(t.position + transform);
                if (_i == 0)
                {
                    t.constraints = 0;
                    _isTouched = false;
                }
            }
            else
            {
                _i++;
                t.MovePosition(t.position - transform);
                if (_i == time)
                {
                    t.constraints = 0;
                    _isTouched = false;
                }
            }
        }
    }

    void trigger()
    {
        var t = GetComponent<Rigidbody>();
        t.constraints = RigidbodyConstraints.FreezeRotation;
        _isTouched = true;
        _toggle = !_toggle;
    }

  
}
