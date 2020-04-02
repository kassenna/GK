using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class star : MonoBehaviour
{


    public float durationTime;
    public Vector3 vec;
    public Vector3 vec1;
    private float smooth;
    // Use this for initialization
    void Start () {
   
    }
 
    // Update is called once per frame
    void Update () {
        smooth = Time.deltaTime * durationTime;
        transform.Rotate(vec);
    }
    private void OnTriggerEnter(Collider other)
    {
        smooth = Time.deltaTime * durationTime;
        transform.Rotate(-vec);
    }
}
