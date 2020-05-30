using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
   public float jumpSpeed = 5f;
   public int jump = 2;
   public int j;

   public int v = 1;
   public int r = 1;

   private Animator anim;
   private Rigidbody rb;
  
  
   void Start ()
   {
      j = jump;
   }

   void Update()
   {
      anim = GetComponent<Animator>();
     
      rb = GetComponent<Rigidbody>();
      if (rb.velocity.y.Equals(0))
         j = 2;
      if (Input.GetKeyDown(KeyCode.Space) && j > 0)
         {
            anim.SetBool("walk", false);
            rb.velocity += jumpSpeed * Vector3.up;
            j--;
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
