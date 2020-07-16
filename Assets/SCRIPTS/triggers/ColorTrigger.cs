﻿using System;
using UnityEngine;
// Katarzyna Majgier


public class ColorTrigger : MonoBehaviour
{
    public Color color;

    public void OnTriggerEnter(Collider other)
    {
        var ren =GetComponent<Renderer>(); 
        ren.material.SetColor("_Color", color);
    }
}