using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class togglemap : MonoBehaviour {
    public GameObject map1;
    public GameObject map2;
    public GameObject map3;
    public GameObject map4;
    public Image image;
    public Sprite map1sprite;
    public Sprite map2sprite;
    public Sprite map3sprite;
    public Sprite map4sprite;
    public int map = 1;
    private void Start()
    {
        map = PlayerPrefs.GetInt("map");
        switch(map)
        {
            case 1:
                image.sprite = map1sprite;
                break;
            case 2:
                image.sprite = map2sprite;
                break;
            case 3:
                image.sprite = map3sprite;
                break;
            case 4:
                image.sprite = map4sprite;
                break;
            default:
                image.sprite = map1sprite;
                break;
        }
    }
    public void right()
    {
        map = PlayerPrefs.GetInt("map");
        if (map < 4)
        map++;
        PlayerPrefs.SetInt("map", map);
        switch(map)
        {
            case 1:
                map1.SetActive(true);
                map2.SetActive(false);
                map3.SetActive(false);
                map4.SetActive(false);
                image.sprite = map1sprite;
                break;
            case 2:
                map1.SetActive(false);
                map2.SetActive(true);
                map3.SetActive(false);
                map4.SetActive(false);
                image.sprite = map2sprite;
                break;
            case 3:
                map1.SetActive(false);
                map2.SetActive(false);
                map3.SetActive(true);
                map4.SetActive(false);
                image.sprite = map3sprite;
                break;
            case 4:
                map1.SetActive(false);
                map2.SetActive(false);
                map3.SetActive(false);
                map4.SetActive(true);
                image.sprite = map4sprite;
                break;
            default:
                map1.SetActive(true);
                map2.SetActive(false);
                image.sprite = map1sprite;
                break;
        }
    }
    public void left()
    {
        map = PlayerPrefs.GetInt("map");
        if (map > 1)
        map--;
        PlayerPrefs.SetInt("map", map);
        switch (map)
        {
            case 1:
                map1.SetActive(true);
                map2.SetActive(false);
                map3.SetActive(false);
                map4.SetActive(false);
                image.sprite = map1sprite;
                break;
            case 2:
                map1.SetActive(false);
                map2.SetActive(true);
                map3.SetActive(false);
                map4.SetActive(false);
                image.sprite = map2sprite;
                break;
            case 3:
                map1.SetActive(false);
                map2.SetActive(false);
                map3.SetActive(true);
                map4.SetActive(false);
                image.sprite = map3sprite;
                break;
            case 4:
                map1.SetActive(false);
                map2.SetActive(false);
                map3.SetActive(false);
                map4.SetActive(true);
                image.sprite = map4sprite;
                break;
            default:
                map1.SetActive(true);
                map2.SetActive(false);
                image.sprite = map1sprite;
                break;
        }
    }
}