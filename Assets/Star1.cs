using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star1 : MonoBehaviour
{
    public float durationTime;
    public Transform gameobject;
    public Vector3 vec;
    private float smooth;
    
    void Update () {
        smooth = Time.deltaTime * durationTime;
        transform.Rotate(vec);
    }
    
    void OnCollisionEnter(Collision coll)
    {
        Destroy(this);
    }
}
