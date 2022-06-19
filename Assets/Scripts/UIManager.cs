using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    GameObject[] pauseObjects;
    void Start()
    {
        Time.timeScale = 1;
        pauseObjects = GameObject.FindGameObjectsWithTag("ShowOnPause");
        hidePaused();
    }

    void Update()
    {
        //use P button to pause and unpause the game
        if(Input.GetKeyDown(KeyCode.P))
        {
            if(Time.timeScale == 1)
            {
                Time.timeScale = 0;
                showPaused();
            }else if (Time.timeScale == 0)
            {
                Time.timeScale = 1;
                hidePaused();
            }
        }
    }

    //controls the pause button
    public void pauseControl()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            showPaused();
        }
        else if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
            hidePaused();
        }
    }

    //show objects with ShowOnPause tag
    public void showPaused()
    {
        foreach(GameObject i in pauseObjects)
        {
            i.SetActive(true);
        }
    }

    //hides objects with ShowOnPause tag
    public void hidePaused()
    {
        foreach(GameObject i in pauseObjects)
        {
            i.SetActive(false);
        }
    }

    //controls for the main menu button
    public void menuControl()
    {
        SceneManager.LoadScene("MenuScene");
    }

    //controls for the quit button
    public void quitGame()
    {
        Application.Quit();
    }
}
