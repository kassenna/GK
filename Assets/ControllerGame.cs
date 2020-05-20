using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControllerGame : MonoBehaviour
{ 
    public Text starsText;
    private static int stars = 0;
    private int maxStars;
  
    private float t;
    public Text time;
    // Start is called before the first frame update
    void Start()
    {
        stars = 0;
        maxStars = GameObject.FindGameObjectsWithTag("star").Length;
        starsText.text = "stars: " +stars+ "/" + maxStars;
        
    }

    public  static void incStar()
    {
        stars++;
    }
    // Update is called once per frame
    void Update()
    {
        t = Time.fixedTime;
        time.text = t.ToString();
        starsText.text = "stars: " + stars + "/" + maxStars;
        
    }
}
