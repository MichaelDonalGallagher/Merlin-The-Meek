using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject HTPMenu;
    public void playGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void HTP()
    {
        mainMenu.SetActive(false);
        HTPMenu.SetActive(true);
    }

    public void back()
    {
        mainMenu.SetActive(true);
        HTPMenu.SetActive(false);
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
