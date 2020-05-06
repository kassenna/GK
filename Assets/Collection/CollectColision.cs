using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectColision : MonoBehaviour
{
    void OnCollisionEnter(Collision coll)
    {
        if(coll.gameObject.tag.Equals("Player"))
        Destroy(gameObject);
    }
}
