using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Expand : MonoBehaviour
{
    public bool trigger = true;

    private Vector3 vec;
    public int steps;
    private float widthX;
    private float widthZ;
    public int end=0;
    public GameObject go;
    private int i;
    // Start is called before the first frame update
    void Start()
    {
        
//        widthX = go.transform.localScale.x;
 //       widthZ = go.transform.localScale.z;
        i = steps;
        vec = new Vector3(widthX/steps, 0, widthZ/steps);
    }

    // Update is called once per frame
    void Update()
    {
        if (trigger && i > end)
        {
            i--;
            go.transform.localScale -= vec;
        }
        if (i < steps && !trigger)
        {
            i++;
//            go.transform.localScale += vec;
        }
    }
}

