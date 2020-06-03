using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class ToggleOn: MonoBehaviour
{
        public Vector3 transforms;
        public int time;
        private bool isTouched = false;
        private Rigidbody t;
        void Start()
        {
            t = GetComponent<Rigidbody>();
            time =(int) transforms.magnitude;
            transforms = transforms / time;
        }

        private void Update()
        {
            if (isTouched )
            {
                time--;
              
                t.position += transforms;
                if (time == 0)
                {
                    isTouched = false;
                    t.constraints = 0;
                }
            }
        }

        void trigger()
        {
            t.constraints = RigidbodyConstraints.FreezeRotation;
            isTouched = true;
        }

       

}
