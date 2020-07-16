using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Katarzyna Majgier

public class SoundTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gameObject.GetComponent<AudioSource>().Play();
         
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gameObject.GetComponent<AudioSource>().Play();
         
        }
    }
      private void OnCollisionExit(Collision other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                gameObject.GetComponent<AudioSource>().Stop();
             
            }
        }
      private void OnTriggerExit(Collider other)
      {
          if (other.gameObject.CompareTag("Player"))
          {
              gameObject.GetComponent<AudioSource>().Stop();
             
          }
      }
}
