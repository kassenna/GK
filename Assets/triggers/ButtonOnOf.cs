using UnityEngine;

namespace triggers
{
    public class ButtonOnOf : MonoBehaviour
    {
        public GameObject gameObjects;

            private void OnTriggerEnter(Collider other)
            {
                if (other.gameObject.tag.Equals("Player"))
                {
                    Debug.Log("dotknęłao");
                    gameObjects.SendMessage("trigger");
                }
            }

    }

    }
