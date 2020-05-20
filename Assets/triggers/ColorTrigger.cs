using System;
using UnityEngine;


public class ColorTrigger : MonoBehaviour
{
    public Color color;

    private void OnEnable()
    {
        GameObject g = gameObject.transform.GetChild(0).gameObject;
        Renderer ren = GetComponent<Renderer>(); 
        ren.material.SetColor("_Color", color);
        ren =g.GetComponent<Renderer>(); 
        ren.material.SetColor("_Color", color);
    }
}