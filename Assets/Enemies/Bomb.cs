using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public float accelerate = 0.1f;
    private bool isTouched = false;
    public float velocity = 0.3f;
    public float timeToExplosion = 5;
    private float timeExplosion = 0.01f;
    
    public float rotate = 20;

    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (isTouched)
        {
            velocity += accelerate;
            rotate += accelerate;
            rb.MovePosition(transform.position + (transform.forward) * (Time.deltaTime * velocity));
            transform.Rotate(Vector3.up * rotate*Time.deltaTime, Space.Self);
            timeToExplosion -= Time.deltaTime;
            if (timeToExplosion < 0)
            {
                timeExplosion -= Time.deltaTime;
               
                //var col = GetComponent<CapsuleCollider>();
                //col.radius = 3;
                if (timeExplosion < 0)
                {
                    var ani = GetComponent<Animator>();
                    ani.SetTrigger("explosion");
                    gameObject.tag = "enemies";
                    //Destroy(gameObject);
                }
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player") || other.gameObject.tag.Equals("noEnemies") )
        {
            var col = GetComponent<Collider>();
            col.isTrigger = false;
            var rb = GetComponent<Rigidbody>();
            rb.useGravity = true;
            isTouched = true;
            
            var ani = GetComponent<Animator>();
            ani.SetBool("walk", true);
        }
    }
}
