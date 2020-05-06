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
   private int j;

   public int v = 1;
   public int r = 1;
   
   public bool hat = false;
   public bool big = false;
   public GameObject hatObject;
   
   public Text starsText;
   private int stars = 0;
   private int maxStars=0;
  
 
   private Animator anim;
   private Rigidbody rb;
  
   private float t;
   public Text time;
   void Start ()
   {
    hatObject.SetActive(false);
   maxStars = GameObject.FindGameObjectsWithTag("star").Length;
   starsText.text = "stars: 0" + "/";// + maxStars);
   j = jump;
   }

   void Update()
   {
      anim = GetComponent<Animator>();
      t = Time.fixedTime;
      time.text = t.ToString();
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
            rb.MovePosition(transform.position + (transform.forward) * (Time.fixedDeltaTime * v));
         }
         else if (Input.GetKey(KeyCode.DownArrow))
         {
            anim.SetBool("walkback", true);
            rb.MovePosition(transform.position - (transform.forward) * (Time.fixedDeltaTime * v));
         }
         if (Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(Vector3.up * (-r * Time.fixedDeltaTime), Space.Self);
         else if (Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(Vector3.up * (+r * Time.fixedDeltaTime), Space.Self);
         if(!Input.anyKey)
         {
         anim.SetBool("walk", false);
         anim.SetBool("walkback", false);
         anim.SetBool("jump", false);
         }
         //if(rb.)
   }
 void OnCollisionEnter(Collision coll)
 {
    if (coll.gameObject.CompareTag("jump"))
    {
   //    j = 0;
    }
    else if (coll.gameObject.CompareTag("star"))
    {
       stars++;
       starsText.text = "stars: " + stars + "/" + maxStars; 
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
