using System;
using UnityEngine;


    public class FinishLevel : MonoBehaviour
    {
        public bool col = false;
        private void OnCollisionEnter(Collision other)
        {
            
            if (other.gameObject.tag == "Player")
            {
#if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit ();
#endif
            }
        }
    }
