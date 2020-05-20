using UnityEngine;


    public class ButtonPressure : MonoBehaviour
    {
         private GameObject gameObjects;
        void Start()
        {
            gameObjects = gameObject.transform.GetChild(0).gameObject;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag.Equals("Player"))
            {
                gameObjects.SendMessage("trigger", 1);
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.tag.Equals("Player"))
            {
                gameObjects.SendMessage("trigger", 0);
            }
        }

}
