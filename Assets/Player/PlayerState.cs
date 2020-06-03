using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static ControllerGame;

public class PlayerState : MonoBehaviour
{
    static public bool hat = false;
    static public bool big = false;
    public GameObject hatObject;
    static public bool completeLevel;
    static public bool isDied;
    // Start is called before the first frame update
    void Start()
    {
        isDied = false;
        completeLevel = false;
        hatObject.SetActive(false);
    }

    private void Update()
    {
        if (gameObject.transform.position.y < -20)
            isDied = true;
    }

    void OnCollisionEnter(Collision coll)
    {
        
        if (coll.gameObject.CompareTag("enemies"))
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
                isDied = true;
            }
        }
    }
}
