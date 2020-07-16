using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Katarzyna Majgier

public class ToggleOnOf : MonoBehaviour
{

    public new Vector3 transform;
    private int time;
    public float velocity;
    private Rigidbody t;
    public int _i;
    private bool _isTouched = false;
    private bool _toggle = false;
    void Start()
    {
        time =  (int)(transform.magnitude/ velocity);
        _i = time;
        transform = transform / time;
        t = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (_isTouched )
        {
       
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
         t.constraints = RigidbodyConstraints.FreezeRotation;
        _isTouched = true;
        _toggle = !_toggle;
    }

  
}
