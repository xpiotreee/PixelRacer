using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour {
    public void startgame()
    {
        SceneManager.LoadScene("game");
        SceneManager.UnloadScene("menu");
    }
    public void shop()
    {
        SceneManager.LoadScene("shop");
        SceneManager.UnloadScene("menu");
    }
    public void upgrades()
    {
        SceneManager.LoadScene("upgrades");
        SceneManager.UnloadScene("menu");
    }
    public void quit()
    {
        Application.Quit();
    }
}