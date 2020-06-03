using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ControllerGame : MonoBehaviour
{
    public GameObject player;
    public Canvas quitMenu;
    public Canvas noPassLevel;
    public Canvas passLevel;
    public Text starsText;
    private static int stars = 0;
    private int maxStars;
    private float t;
    public Text time;
    void Start()
    {
        Time.timeScale = 1;
        stars = 0;
        maxStars = GameObject.FindGameObjectsWithTag("star").Length;
        starsText.text = "stars: " +stars+ "/" + maxStars;
        
    }
    public  static void incStar()
    {
        stars++;
    }
    void Update()
    {
        t = Time.fixedTime;
        time.text = ((int)t).ToString();
        starsText.text = "stars: " + stars + "/" + maxStars;
        if (PlayerState.completeLevel)
        {
            Time.timeScale = 0;
            passLevel.gameObject.SetActive(true);
        }
        else if(PlayerState.isDied)
        {
            Time.timeScale = 0;
            noPassLevel.gameObject.SetActive(true);
        }
    }
    public void bClickExit()
    {
        Time.timeScale = 0;
        quitMenu.gameObject.SetActive(true);
    }
    public void bReturnToGame()
    {
        Time.timeScale = 1;
        quitMenu.gameObject.SetActive(false);
        
    }
    public void bgoToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void bNextLevel()
    {
        int sceneNmbr = SceneManager.GetActiveScene().buildIndex + 1;
        if(sceneNmbr < SceneManager.sceneCountInBuildSettings+1)
        SceneManager.LoadScene(sceneNmbr);
        else
        {
            SceneManager.LoadScene("Menu");
        }
    }

    public void bRetry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
