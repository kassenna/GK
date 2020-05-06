using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float durationTime;
    public Vector3 vec;
    private float smooth;
    
    void Update () {
        smooth = Time.deltaTime * durationTime;
        transform.Rotate(-vec);
    }
    

}
