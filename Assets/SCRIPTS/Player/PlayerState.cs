using UnityEngine;

//Katarzyna MAjgier
public class PlayerState : MonoBehaviour
{
    static public bool hat = false;
    static  public bool big = false;
    public GameObject hatObject;
    static public bool completeLevel;
    static public bool isDied;
    void Start()
    {
        hatObject.SetActive(hat);
        if(big)
            gameObject.transform.localScale += new Vector3(0, 0.15f, 0);
    }

    private void Update()
    {
        if (gameObject.transform.position.y < -20)
            {isDied = true;
            hat = false;
            big = false;
            
            }
        hatObject.SetActive(hat);
    }

    void collisionPresent()
    {
        if (PlayerState.big)
        {
            PlayerState.hat = true;
                
        }
        else
        {
            PlayerState.big = true;
            gameObject.transform.localScale += new Vector3(0, 0.15f, 0);
        }

    
    }

 
    void OnCollisionEnter(Collision coll)
    {
      if (coll.gameObject.CompareTag("enemies"))
        {
            if (hat)
            {
                hat = false;
              }
            else if (big)
            {
                big = false;
                gameObject.transform.localScale -= new Vector3(0, 0.15f, 0);
            }
            else
            {
                isDied = true;
            }
        }
    }
}
