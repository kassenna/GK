using UnityEngine;


    public class ButtonOn : MonoBehaviour
    {
        public GameObject gameObjects;

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag.Equals("Player"))
            {
                gameObjects.SendMessage("trigger");
                gameObject.SetActive(false);
            }
        }

    }
