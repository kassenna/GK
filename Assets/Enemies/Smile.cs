using System;
using UnityEngine;



    public class Smile : MonoBehaviour
    {
        private bool isRotate;
        public float vec;
        public float velocity;
        private int step;
        private Animator anim;
        public float rotate = 1;
        public float jump;
        private int i;
       

        private void Start()
        {
            step = (int)(vec/velocity);
            i = step;
            
            transform.localPosition = new Vector3(0,0,0);
        }

        private void Update()
        {
         /*   i--;
            if (i == 0)
            {
                transform.Rotate(Vector3.up * 180, Space.Self); 
                i = step;
            }
            var rb = GetComponent<Rigidbody>();
            if (rb.velocity.y.Equals(0))
            rb.velocity += jump * Vector3.up;
            rb.MovePosition(transform.position + (transform.forward)* velocity);
*/
            /* anim = GetComponent<Animator>();
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
             */
        }
    }
