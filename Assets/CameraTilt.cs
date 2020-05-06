using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTilt : MonoBehaviour
{
    const float MIN_X = 0.0f;
    const float MAX_X = 10.0f;
    const float MIN_Y = -10.0f;
    const float MAX_Y = 10.0f;
    private float x;
    private float y;
 
    public float Sensitivity =0.0001f;
 
    void Awake()
    {
        Vector3 euler = transform.rotation.eulerAngles;
        x = euler.x;
        y = euler.y;
    }
 
    void Update()
    {
       
        x += Input.GetAxis("Mouse X") * (Sensitivity * Time.deltaTime);
        if (x < MIN_X) x += MAX_X;
        else if (x > MAX_X) x -= MAX_X;
        y -= Input.GetAxis("Mouse Y") * (Sensitivity * Time.deltaTime);
        if (y < MIN_Y) y = MIN_Y;
        else if (y > MAX_Y) y = MAX_Y;
 
        transform.rotation = Quaternion.Euler(y, x, 0.0f);
    }

   
}
