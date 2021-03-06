﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Katarzyna Majgier
public class Present : MonoBehaviour
{
  
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.SendMessage("collisionPresent");
            gameObject.GetComponentInParent<AudioSource>().Play();
            Destroy(gameObject);
        }
    }
}
