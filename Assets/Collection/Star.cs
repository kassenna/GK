using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        ControllerGame.incStar();
        gameObject.GetComponentInParent<AudioSource>().Play();

        Destroy(gameObject);
        }
    }

