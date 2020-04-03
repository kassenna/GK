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
   private int stars = 0;
   public Text text;
   public Text time;
   private int maxStars;
   public int v = 1;
   public int r = 1;
   private float t;
   void Start ()
   {
    
      var maxStars = GameObject.FindGameObjectsWithTag("star").Length;
      text.text = "stars: " + stars + "/" + this.maxStars;
      
      j = jump;
   }
 
 void Update()
 {
    t = Time.fixedTime;
    time.text = t.ToString();
    Rigidbody rb= GetComponent<Rigidbody>();
       
    if (Input.GetKeyDown (KeyCode.Space ) && j > 0 )
    {
       rb.velocity += jumpSpeed * Vector3.up;
       j--;
    } 
    if (Input.GetKey(KeyCode.UpArrow))
       rb.MovePosition(transform.position + (transform.forward) * (Time.fixedDeltaTime * v));
    else if (Input.GetKey(KeyCode.DownArrow))
       rb.MovePosition(transform.position - (transform.forward) * (Time.fixedDeltaTime * v));
    if (Input.GetKey(KeyCode.RightArrow))
       transform.Rotate(Vector3.up * (-r * Time.fixedDeltaTime), Space.Self);
    else if (Input.GetKey(KeyCode.LeftArrow))
       transform.Rotate(Vector3.up * (+r * Time.fixedDeltaTime), Space.Self);
 }
 void OnCollisionEnter(Collision coll)
 {
    if(coll.gameObject.CompareTag("JUMP"))
          j = jump;
    if (coll.gameObject.CompareTag("star"))
    {
       stars++;
       text.text = "stars: " + stars + "/" + maxStars; 
    }
 }
 
}
