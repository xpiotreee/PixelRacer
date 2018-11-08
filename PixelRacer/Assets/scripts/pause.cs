using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pause : MonoBehaviour {
    public static bool ispaused = false;
    public bool enemyon = false;
    public GameObject enemy;
    public GameObject pauseMenu;
    public GameObject mapMenuUI;
    public GameObject pauseMenuUI;
    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (ispaused)
            {
                Resume();
                Debug.Log("resume");
            } else
            {
                Debug.Log("pause");
                Pause();
            }
        }
    }
    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        ispaused = false;
    }
    public void Pause()
    {
        pauseMenu.SetActive(true);
        pauseMenuUI.SetActive(true);
        mapMenuUI.SetActive(false);
        Time.timeScale = 0f;
        ispaused = true;
    }
    public void map()
    {
        pauseMenuUI.SetActive(false);
        mapMenuUI.SetActive(true);
    }
    public void map1()
    {
        Resume();
        GetComponent<playerscript>().map1load();
    }
    public void map2()
    {
        Resume();
        GetComponent<playerscript>().map2load();
    }
    public void menu()
    {
        SceneManager.LoadScene("menu");
        Time.timeScale = 1f;
        SceneManager.UnloadScene("game");
    }
}