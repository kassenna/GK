using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerState : MonoBehaviour
{
    public bool hat = false;
    public bool big = false;
    public GameObject hatObject;
    // Start is called before the first frame update
    void Start()
    {
        hatObject.SetActive(false);
    }
    void OnCollisionEnter(Collision coll)
    {
       if (coll.gameObject.CompareTag("star"))
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
            {
                SceneManager.LoadScene(0, LoadSceneMode.Single);
            }
        }
    }
}
