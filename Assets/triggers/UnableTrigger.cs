using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnableTrigger : MonoBehaviour
{
    public GameObject gameObjects;
    public void OnTriggerEnter(Collider other)
    {
        gameObjects.SendMessage("unableTrigger", true);    
    }
    public void unActiveChildren()
    {
        gameObjects.SendMessage("unActiveChildren");
        gameObject.SetActive(false); 
    }
    public void OnCollisionEnter(Collision other)
    {
       unActiveChildren();
    }
}
