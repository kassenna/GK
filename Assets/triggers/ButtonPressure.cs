using UnityEngine;


    public class ButtonPressure : MonoBehaviour
    {
         public GameObject gameObjects;

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
