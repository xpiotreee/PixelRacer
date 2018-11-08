using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class shop : MonoBehaviour {
    public Text text1;
    public Text text2;
    public Text text3;
    public Text text4;
    public Text pointsdisplay;
    public GameObject codepanel;
    public Text codetext;
    public int isavaible1 = 0;
    public int isavaible2 = 0;
    public int isavaible3 = 0;
    int points;
    public static int choose;
    private void Start()
    {
        isavaible1 = PlayerPrefs.GetInt("isavaible1");
        isavaible2 = PlayerPrefs.GetInt("isavaible2");
        isavaible3 = PlayerPrefs.GetInt("isavaible3");
        points = PlayerPrefs.GetInt("score");
        choose = PlayerPrefs.GetInt("skin");
    }
    void Update () {
        if (Input.GetKeyDown(KeyCode.Escape)) exit();
        pointsdisplay.text = "Points: " + points;
		if (choose == 0)
        {
            text1.text = "Selected";
        } else
        {
            text1.text = "Select";
        }
        if (choose == 1)
        {
            text2.text = "Selected";
        }else
        {
            if (isavaible1 == 1)
            {
                text2.text = "Select";
            } else
            {
                text2.text = "Buy 10";
            }
        }
        if (choose == 2)
        {
            text3.text = "Selected";
        }else
        {
            if (isavaible2 == 1)
            {
                text3.text = "Select";
            } else
            {
                text3.text = "Buy 50";
            }
        }
        if (choose == 3)
        {
            text4.text = "Selected";
        }else
        {
            if (isavaible3 == 1)
            {
                text4.text = "Select";
            } else
            {
                text4.text = "Buy 100";
            }
        }
	}
    public void click0()
    {
        choose = 0;
        PlayerPrefs.SetInt("skin", choose);
    }
    public void click1()
    {
        if (isavaible1 == 1)
        {
            choose = 1;
            PlayerPrefs.SetInt("skin", choose);
        } else if (isavaible1 == 0 && points >= 10)
        {
            isavaible1 = 1;
            PlayerPrefs.SetInt("isavaible1", 1);
            points -= 10;
            PlayerPrefs.SetInt("score", points);
            choose = 1;
            PlayerPrefs.SetInt("skin", choose);
        }
    }
    public void click2()
    {
        if (isavaible2 == 1)
        {
            choose = 2;
            PlayerPrefs.SetInt("skin", choose);
        } else if (isavaible2 == 0 && points >= 50)
        {
            isavaible2 = 1;
            PlayerPrefs.SetInt("isavaible2", 1);
            points -= 50;
            PlayerPrefs.SetInt("score", points);
            choose = 2;
            PlayerPrefs.SetInt("skin", choose);
        }
    }
    public void click3()
    {
        if (isavaible3 == 1)
        {
            choose = 3;
            PlayerPrefs.SetInt("skin", choose);
        } else if (isavaible3 == 0 && points >= 100)
        {
            isavaible3 = 1;
            PlayerPrefs.SetInt("isavaible3", 1);
            points -= 100;
            PlayerPrefs.SetInt("score", points);
            choose = 3;
            PlayerPrefs.SetInt("skin", choose);
        }
    }
    public void codepanelon()
    {
        codepanel.SetActive(true);
    }
    public void codepaneloff()
    {
        codepanel.SetActive(false);
    }
    public void entercode()
    {
        if (codetext.text == "piotreee")
        {
            if (PlayerPrefs.GetInt("codeused") != 1)
            {
                points += 50;
                PlayerPrefs.SetInt("score", points);
                PlayerPrefs.SetInt("codeused", 1);
            }
        }
        //else if (codetext.text == "DEBUG")
        //{
        //        points += 50;
        //        PlayerPrefs.SetInt("score", points);
        //        PlayerPrefs.SetInt("codeused", 1);
        //}
    }
    void exit()
    {
        SceneManager.LoadScene("menu");
        SceneManager.UnloadScene("shop");
    }
}