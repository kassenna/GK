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
   
   public bool hat = false;
   public bool big = false;
   public GameObject hatObject;
   
 
   private Animator anim;
   private Rigidbody rb;
  
  
   void Start ()
   {
    hatObject.SetActive(false);

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
 void OnCollisionEnter(Collision coll)
 {
    if (coll.gameObject.CompareTag("jump"))
    {
   //    j = 0;
    }
    else if (coll.gameObject.CompareTag("star"))
    {
       ControllerGame.incStar();
    }
    else if (coll.gameObject.CompareTag("present"))
    {
       if (big)
       {
          hatObject.SetActive(true);
          hat = true;
       }
       else
       {
          big = true;
          gameObject.transform.localScale += new Vector3(0, 0.15f, 0);
       }
    }
    else if (coll.gameObject.CompareTag("enemies"))
    {
       if (hat)
       {
          hat = false;
          hatObject.SetActive(false);
       }
       else if (big)
       {
          big = false;
          gameObject.transform.localScale -= new Vector3(0, 0.15f, 0);
       }
       else
       { }
    }
 }
 
}
