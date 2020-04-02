using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectColision : MonoBehaviour
{
    void OnCollisionEnter(Collision coll)
    {
        Destroy(gameObject);
    }
}
