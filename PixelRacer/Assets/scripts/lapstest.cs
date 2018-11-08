using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UI;

public class lapstest : MonoBehaviour {
    public Text mytext;
    public Text mytext2;
    public GameObject enemytank;
    public static int scorepoints;
    public int morepoints = 1;
    public int pointsamp = 1;
    public int streakpoints;
    public static bool s1 = false;
    public static bool s2 = false;
    public static bool s3 = false;
    public static bool s4 = false;
    public static bool s5 = false;
    private void Start()
    {
        scorepoints = PlayerPrefs.GetInt("score");
        mytext.text = "Points: ";
    }
    private void Update()
    {
        if (s1 == true && s2 == true && s3 == true && s4 == true && s5 == true)
        {
            streakpoints++;
            if(streakpoints == 3)
            {
                pointsamp ++;
                streakpoints = 0;
            }
            scorepoints += pointsamp * morepoints;
            PlayerPrefs.SetInt("score", scorepoints);
            s1 = false;
            s2 = false;
            s3 = false;
            s4 = false;
            s5 = false;
        }
        mytext.text = "Points: " + scorepoints;
        mytext2.text = "x " + pointsamp * morepoints;
        if (enemytank.activeSelf) morepoints = 2;
        if (!(enemytank.activeSelf)) morepoints = 1;
    }
    void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.tag == "line1")
        {
            s1 = true;
            Debug.Log("s1: true");
        }
        if (collider.tag == "line2")
        {
            if (s1 == true)
            {
                s2 = true;
            }
            Debug.Log("s2: true");
        }
        if (collider.tag == "line3")
        {
            if (s2 == true)
            {
                s3 = true;
            }
            Debug.Log("s3: true");
        }
        if (collider.tag == "line4")
        {
            if (s3 == true)
            {
                s4 = true;
            }
            Debug.Log("s4: true");
        }
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "line1")
        {
            if (s4 == true)
            {
                s5 = true;
                Debug.Log("s5: true");
            }
        }
    }
}