using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
   public float jumpSpeed = 5f;//or whatever you want it to be
   public int jump = 2;
   public int j;
   void Start ()
   {
      j = jump;
   }
 
 void Update(){
    Rigidbody rb= GetComponent<Rigidbody>();
       if (Input.GetKeyDown (KeyCode.Space ) && j>0 ){
          rb.velocity += jumpSpeed * Vector3.up;
          j--;
       }
    }
 void OnCollisionEnter(Collision coll)
 {
    
  
       
    {
       if(coll.gameObject.tag == "JUMP")
          j = jump;
    }
 }
}
