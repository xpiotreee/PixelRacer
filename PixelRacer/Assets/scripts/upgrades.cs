using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class upgrades : MonoBehaviour {
    public int points;
    public int help;
    public int lvl1 = 1;
    public int lvl2 = 1;
    public int lvl3 = 1;
    public int price1 = 5;
    public int price2 = 5;
    public int price3 = 5;
    public int choose1 = 1;
    public int choose2 = 1;
    public int choose3 = 1;
    public int upgrade1 = 1;
    public int upgrade2 = 1;
    public int upgrade3 = 1;
    public Text text1;
    public Text text2;
    public Text text3;
    public Text text4;
    public Image bar1;
    public Image bar2;
    public Image bar3;
    public Sprite bartxt1;
    public Sprite bartxt2;
    public Sprite bartxt3;
    public Sprite bartxt4;
    public Sprite bartxt5;
    public Sprite bartxt6;
    public Sprite bartxt7;
    public Sprite bartxt8;
	void Start () {
        //PlayerPrefs.SetInt("lvl1", 0);
        //PlayerPrefs.SetInt("lvl2", 0);
        //PlayerPrefs.SetInt("lvl3", 0);
        //PlayerPrefs.SetInt("choose1", 0);
        //PlayerPrefs.SetInt("choose2", 0);
        //PlayerPrefs.SetInt("choose3", 0);
        //PlayerPrefs.SetInt("price1", 0);
        //PlayerPrefs.SetInt("price2", 0);
        //PlayerPrefs.SetInt("price3", 0);
        //PlayerPrefs.SetInt("upgrade1", 0);
        //PlayerPrefs.SetInt("upgrade2", 0);
        //PlayerPrefs.SetInt("upgrade3", 0);
        points = PlayerPrefs.GetInt("score");
        help = PlayerPrefs.GetInt("lvl1");
        if (help != 0)
        lvl1 = PlayerPrefs.GetInt("lvl1");
        help = PlayerPrefs.GetInt("choose1");
        if (help != 0)
            choose1 = PlayerPrefs.GetInt("choose1");
        help = PlayerPrefs.GetInt("price1");
        if (help != 0)
            price1 = PlayerPrefs.GetInt("price1");
        help = PlayerPrefs.GetInt("lvl2");
        if (help != 0)
            lvl2 = PlayerPrefs.GetInt("lvl2");
        help = PlayerPrefs.GetInt("choose2");
        if (help != 0)
            choose2 = PlayerPrefs.GetInt("choose2");
        help = PlayerPrefs.GetInt("price2");
        if (help != 0)
            price2 = PlayerPrefs.GetInt("price2");
        help = PlayerPrefs.GetInt("lvl3");
        if (help != 0)
            lvl3 = PlayerPrefs.GetInt("lvl3");
        help = PlayerPrefs.GetInt("choose3");
        if (help != 0)
            choose3 = PlayerPrefs.GetInt("choose3");
        help = PlayerPrefs.GetInt("price3");
        if (help != 0)
            price3 = PlayerPrefs.GetInt("price3");
    }
	void Update () {
        if(Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("menu");
            SceneManager.UnloadScene("upgrades");
        }
        text4.text = "" + points;
        if (lvl1 != 8)
        text1.text = "Buy: " + price1;
        if (lvl1 == 8)
            text1.text = "Max";
        if (lvl2 != 8)
        text2.text = "Buy: " + price2;
        if (lvl2 == 8)
            text2.text = "Max";
        if (lvl3 != 8)
        text3.text = "Buy: " + price3;
        if (lvl3 == 8)
            text3.text = "Max";
        switch(choose1)
        {
            case 1:
                bar1.sprite = bartxt1;
                upgrade1 = 1;
                break;
            case 2:
                bar1.sprite = bartxt2;
                break;
            case 3:
                bar1.sprite = bartxt3;
                break;
            case 4:
                bar1.sprite = bartxt4;
                break;
            case 5:
                bar1.sprite = bartxt5;
                break;
            case 6:
                bar1.sprite = bartxt6;
                break;
            case 7:
                bar1.sprite = bartxt7;
                break;
            case 8:
                bar1.sprite = bartxt8;
                break;
        }
        switch (choose2)
        {
            case 1:
                bar2.sprite = bartxt1;
                break;
            case 2:
                bar2.sprite = bartxt2;
                break;
            case 3:
                bar2.sprite = bartxt3;
                break;
            case 4:
                bar2.sprite = bartxt4;
                break;
            case 5:
                bar2.sprite = bartxt5;
                break;
            case 6:
                bar2.sprite = bartxt6;
                break;
            case 7:
                bar2.sprite = bartxt7;
                break;
            case 8:
                bar2.sprite = bartxt8;
                break;
        }
        switch (choose3)
        {
            case 1:
                bar3.sprite = bartxt1;
                break;
            case 2:
                bar3.sprite = bartxt2;
                break;
            case 3:
                bar3.sprite = bartxt3;
                break;
            case 4:
                bar3.sprite = bartxt4;
                break;
            case 5:
                bar3.sprite = bartxt5;
                break;
            case 6:
                bar3.sprite = bartxt6;
                break;
            case 7:
                bar3.sprite = bartxt7;
                break;
            case 8:
                bar3.sprite = bartxt8;
                break;
        }

	}
    public void buybutton1()
    {
        if (points >= price1 && lvl1 < 8)
        {
            points -= price1;
            lvl1++;
            choose1++;
            price1 *= 2;
            PlayerPrefs.SetInt("score", points);
            PlayerPrefs.SetInt("lvl1", lvl1);
            PlayerPrefs.SetInt("choose1", choose1);
            PlayerPrefs.SetInt("price1", price1);
        }
    }
    public void chooselvl1(int a)
    {
        if (choose1 < 8 && a == 1 && choose1 < lvl1)
        {
            choose1++;
            PlayerPrefs.SetInt("choose1", choose1);
        }
        if (choose1 > 1 && a == -1)
        {
            choose1--;
            PlayerPrefs.SetInt("choose1", choose1);
        }
    }
    public void buybutton2()
    {
        if (points >= price2 && lvl2 < 8)
        {
            points -= price2;
            lvl2++;
            choose2++;
            price2 *= 2;
            PlayerPrefs.SetInt("score", points);
            PlayerPrefs.SetInt("lvl2", lvl2);
            PlayerPrefs.SetInt("choose2", choose2);
            PlayerPrefs.SetInt("price2", price2);
        }
    }
    public void chooselvl2(int a)
    {
        if (choose2 < 8 && a == 1 && choose2 < lvl2)
        {
            choose2++;
            PlayerPrefs.SetInt("choose2", choose2);
        }
        if (choose2 > 1 && a == -1)
        {
            choose2--;
            PlayerPrefs.SetInt("choose2", choose2);
        }
    }
    public void buybutton3()
    {
        if (points >= price3 && lvl3 < 8)
        {
            points -= price3;
            lvl3++;
            choose3++;
            price3 *= 2;
            PlayerPrefs.SetInt("score", points);
            PlayerPrefs.SetInt("lvl3", lvl3);
            PlayerPrefs.SetInt("choose3", choose3);
            PlayerPrefs.SetInt("price3", price3);
        }
    }
    public void chooselvl3(int a)
    {
        if (choose3 < 8 && a == 1 && choose3 < lvl3)
        {
            choose3++;
            PlayerPrefs.SetInt("choose3", choose3);
        }
        if (choose3 > 1 && a == -1)
        {
            choose3--;
            PlayerPrefs.SetInt("choose3", choose3);
        }
    }
}