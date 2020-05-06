using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class MonostableButton : MonoBehaviour
{
        public Color color;
        private Renderer ren;
        public Vector3 transforms;
        public int time;
        private bool isTouched = false;
        public GameObject gameObjects;
        void Start()
        {
            time =(int) transforms.magnitude*10;
            ren = GetComponent<Renderer>();
            ren.material.SetColor("_Color", color);
            var ren2 = gameObject.GetComponent<Renderer>();
            ren2.material.SetColor("_Color", color);
            transforms = transforms / time;
        }

        private void Update()
        {
            
            if (isTouched )
            {
                time--;
                var t = gameObjects.GetComponent<Rigidbody>();
                //t.constraints.
                t.MovePosition(t.position + transforms);
                if (time == 0)
                {
                    isTouched = false;
                    t.constraints = 0;
                     Destroy(gameObject);
                }
            }
        }

        private void OnTriggerEnter(Collider other)
        {
           
            var t = gameObjects.GetComponent<Rigidbody>();
            t.constraints = RigidbodyConstraints.FreezeRotation;
           
            isTouched = true;


        }
  

}
