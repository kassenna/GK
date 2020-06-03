using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public void trigger()
    {
        gameObject.SetActive(!gameObject.active);
    }
}
