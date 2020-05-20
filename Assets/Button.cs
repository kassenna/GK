using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
   
    private Scene scene;
    // Use this for initialization
    public void bPlay()
    {
 
        var parameters = new LoadSceneParameters(LoadSceneMode.Additive);
        scene = SceneManager.LoadScene("Scenes/MyScenes/L1", parameters);
        Debug.Log("Load 1 of scene2: " + scene.name);
    }

    public void bExit()
    {
        Application.Quit();
    }
}
