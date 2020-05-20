using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    private bool isTouched = false;
    public float velocity = 1;
    public float timeExplosion = 1;
    public float rotate = 20;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.tag = "Untagged";
    }

    // Update is called once per frame
    void Update()
    {
        if (isTouched)
        {
            var rb = GetComponent<Rigidbody>();
            rb.MovePosition(transform.position + (transform.forward) * (Time.deltaTime * velocity));
            transform.Rotate(Vector3.up * rotate*Time.deltaTime, Space.Self);
            timeExplosion -= Time.deltaTime;
            if (timeExplosion < 0)
            {
                tag = "enemies";
                var ani = GetComponent<Animator>();
                ani.SetTrigger("explosion");
            }
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            isTouched = true;
            var ani = GetComponent<Animator>();
            ani.SetBool("walk", true);
        }
    }
}
