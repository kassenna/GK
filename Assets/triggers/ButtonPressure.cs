using UnityEngine;


    public class ButtonPressure : MonoBehaviour
    {
         public GameObject gameObjects;
         public bool trigger = true;
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag.Equals("Player") && trigger)
            {
                gameObjects.SendMessage("trigger", true);
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.tag.Equals("Player") && trigger)
            {
                gameObjects.SendMessage("trigger", false);
            }
        }

}
