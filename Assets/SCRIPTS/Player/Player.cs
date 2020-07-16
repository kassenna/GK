using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
// Katarzyna Majgier, Adam Hudziak
public class Player : MonoBehaviour
{
   public float jumpSpeed = 5f;
   public int jump = 2;
   private int j;

   public int v = 20;
   public int r = 1;

   private Animator anim;
   private Rigidbody rb;
  
  
   void Start ()
   {
      anim = GetComponent<Animator>();
      j = jump;
      rb = GetComponent<Rigidbody>();
     
   }



   void Update()
   {
     if (rb.velocity.y.Equals(0))
                   j = 2;
      if (Input.GetKeyDown(KeyCode.Space) && j > 0)
     {
        rb.velocity += jumpSpeed * Vector3.up;
        j--; 
        anim.SetBool("walk", false);
     }
         if (Input.GetKey(KeyCode.UpArrow))
         {
            anim.SetBool("walk", true);
            rb.MovePosition(transform.position + (transform.forward) * (Time.deltaTime * v));
         }
         else if (Input.GetKey(KeyCode.DownArrow))
         {
            anim.SetBool("walkback", true);
            rb.MovePosition(transform.position - (transform.forward) * (Time.deltaTime * v));
         }
         if (Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(Vector3.up * (-r * Time.deltaTime), Space.Self);
         else if (Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(Vector3.up * (+r * Time.deltaTime), Space.Self);
         if(!Input.anyKey)
         {
         anim.SetBool("walk", false);
         anim.SetBool("walkback", false);
         }
    
         

   }
}
