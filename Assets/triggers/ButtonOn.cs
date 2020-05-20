using UnityEngine;


    public class ButtonOn : MonoBehaviour
    {
        public GameObject gameObjects;
        void Start()
        {
            gameObjects= gameObject.transform.GetChild(0).gameObject;

        }
    
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag.Equals("Player"))
            {
                gameObjects.SendMessage("trigger");
                gameObject.SetActive(false);
            }
        }

    }
