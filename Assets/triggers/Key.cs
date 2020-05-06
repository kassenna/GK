using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public Color color;
    private Renderer ren;
    public GameObject gameObjects;
    void Start()
    {
        ren = GetComponent<Renderer>();
        ren.material.SetColor("_Color", color);
        var ren2 = gameObject.GetComponent<Renderer>();
        ren2.material.SetColor("_Color", color);
    }
    private void OnTriggerEnter(Collider other)
    {
    Destroy(gameObjects);
    Destroy(gameObject);

    }

}
