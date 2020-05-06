using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Turtle : MonoBehaviour
{
    public float velocity = 5;
    public float time;
    private Random random;
    public float angle = 90;
    private Animator anim;
    private bool spikes = true;
    private void Start()
    {
        time = (float)(Random.value%10)/10.0f;
    }

    // Update is called once per frame
    void Update()
    {
        
        time -= Time.deltaTime;
        if (time < 0)
        {
            anim = GetComponent<Animator>();
            time =2+ (float) (Random.value % 10) / 10.0f;
            if (spikes)
            {
                anim.SetBool("spikes", true);
                spikes = false;
            }
            else
            {
                anim.SetBool("spikes", false);
                spikes = true;
            }
            if(spikes)
                gameObject.transform.position += velocity * transform.forward;
        }
        
       
    }

    private void OnCollisionEnter(Collision other)
    {
        transform.Rotate(new Vector3(0, 1, 0), angle);
    }
}
