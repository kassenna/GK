using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
  public float jumpSpeed = 5f;//or whatever you want it to be
  public int time = 10;
  private int i=0;
  
  
  void Start ()
  {
    i=time;
  }
 
 void Update(){
    Rigidbody rb= GetComponent<Rigidbody>();
    
    i--;
    if(i==0){
      rb.velocity += jumpSpeed * Vector3.up;
      i = time;
    }
 }
 
}
