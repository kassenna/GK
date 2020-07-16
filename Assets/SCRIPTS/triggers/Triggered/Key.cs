using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Katarzyna Majgier

public class Key : MonoBehaviour
{
    public void unableTrigger()
    {
        var col = GetComponent<Collider>();
        col.isTrigger = true;
    }

    public void trigger()
    {
        gameObject.SetActive(false);
    }
}
