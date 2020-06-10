using UnityEngine;

namespace triggers
{
    public class ButtonOnOf : MonoBehaviour
    {
        public bool trigger = true;
        public GameObject gameObjects;

            private void OnTriggerEnter(Collider other)
            {
                if (other.gameObject.tag.Equals("Player") && trigger)
                {
                    Debug.Log("dotknęłao");
                    gameObjects.SendMessage("trigger");
                }
            }

    }

    }
