using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BistableButton : MonoBehaviour
{
    public Color color;
    private Renderer ren;
    public Vector3 transform;
    public int time;
    public int velocity;
    private int i;
    private bool isTouched = false;
    public GameObject gameObjects;
    private bool toggle = false;
    void Start()
    {
        time = velocity * (int)transform.magnitude;
        i = time;
        ren = GetComponent<Renderer>();
        ren.material.SetColor("_Color", color);
        var ren2 = gameObject.GetComponent<Renderer>();
        ren2.material.SetColor("_Color", color);
        transform = transform / time;
    }

    private void Update()
    {
        if (isTouched )
        {
            var t = gameObjects.GetComponent<Rigidbody>();
            if (toggle)
            {
                i--;
                t.MovePosition(t.position + transform);
                if (i == 0)
                {
                    t.constraints = 0;
                    isTouched = false;
                }
            }
            else
            {
                i++;
                t.MovePosition(t.position - transform);
                if (i == time)
                {
                    t.constraints = 0;
                    isTouched = false;
                }
            }
        }
    }
    

    private void OnTriggerEnter(Collider other)
    {
        var t = gameObjects.GetComponent<Rigidbody>();
        t.constraints = RigidbodyConstraints.FreezeRotation;
        isTouched = true;
        toggle = !toggle;
    }
}
