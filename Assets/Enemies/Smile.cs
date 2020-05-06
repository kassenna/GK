using System;
using UnityEngine;



    public class Smile : MonoBehaviour
    {
        private bool isRotate;
        public int steps;
        public int stepRotate;
        private int step;
        private Animator anim;
        public float velocity = 0.01f;
        public float rotate = 1;

        private void Start()
        {
            step = steps;
        }

        private void Update()
        {
            anim = GetComponent<Animator>();
            if (isRotate)
            {
                gameObject.transform.position += velocity * transform.forward;
                if (step == 0)
                {
                    anim.SetBool("isRotate", true);
                    step = steps;
                    isRotate = false;
                }
            }
            else
            {
                transform.Rotate(Vector3.up * rotate*(- Time.fixedDeltaTime), Space.Self); 
                if (step == 0)
                {
                    anim.SetBool("isRotate", false);
                    step = steps;
              
                    isRotate = true;
                }
            }
            step--;
            
        }
    }
