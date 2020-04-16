using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public Color color;
    public Color color2;
    private Renderer ren;
    public GameObject gameObject;
    void Start()
    {
        ren = GetComponent<Renderer>();
        ren.material.SetColor("_Color", color);
    }


    private void OnTriggerEnter(Collider other)
    {
        ren.material.SetColor("_Color", color2);
        var ren2 = gameObject.GetComponent<Renderer>();
        ren2.material.SetColor("_Color", color);
        
    }
}
