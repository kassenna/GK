using UnityEngine;

// Katarzyna Majgier
    public class ButtonOn : MonoBehaviour
    {
        public bool trigger = true;
        public GameObject gameObjects;

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag.Equals("Player") && trigger)
            {
                gameObjects.SendMessage("trigger");
                gameObject.SetActive(false);
            }
        }

    }
