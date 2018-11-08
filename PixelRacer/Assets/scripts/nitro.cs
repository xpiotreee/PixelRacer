using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class nitro : MonoBehaviour {
    //Vector2 speednitro = new Vector2(0, 30);
    public static bool nitroavaible = false;
    public bool usenitro = false;
    public Image image;
    public Sprite nitro0;
    public Sprite nitro1;
    public Sprite nitro2;
    public Sprite nitro3;
	void Start () {
        image.sprite = nitro0;
        StartCoroutine(nitrocooldown());
	}
	void FixedUpdate()
    {
        if (usenitro == true && nitroavaible == true)
        {
            image.sprite = nitro0;
            nitroavaible = false;
            usenitro = false;
            GetComponent<playerscript>().nitroused();
            StartCoroutine(nitrocooldown());
        }
        usenitro = false;
    }
	IEnumerator nitrocooldown()
    {
        print(Time.time);
        yield return new WaitForSeconds(2);
        image.sprite = nitro1;
        yield return new WaitForSeconds(2);
        image.sprite = nitro2;
        yield return new WaitForSeconds(2);
        image.sprite = nitro3;
        print(Time.time);
        nitroavaible = true;
    }
    public void UseNitro()
    {
        usenitro = true;
    }
}