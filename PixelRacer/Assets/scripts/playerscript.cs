using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerscript : MonoBehaviour
{
    public bool bulletavaible = true;
    public int help;
    public float upgradeamp1;
    public float upgradeamp2;
    public float upgradeamp3;
    Rigidbody2D rb2d;
    public float speed = 0.3f;
    float drag;
    float movements;
    float rotationresult;
    float rotation;
    public float amplifier = 0.01f;
    public SpriteRenderer spriterender;
    int skin;
    bool vinputuse;
    bool rotationuse;
    float rotationamp;
    public float movementsresult;
    public Sprite defaultcar;
    public Sprite blue;
    public Sprite white;
    public Sprite tank;
    public GameObject bullet;
    public GameObject setmap1;
    public GameObject setmap2;
    public GameObject setmap3;
    public GameObject setmap4;
    public GameObject pausebuttons;
    public static GameObject map_1;
    public static GameObject map_2;
    public static GameObject map_3;
    public static GameObject map_4;
    public GameObject firebutton1;
    public GameObject firebutton2;
    public GameObject panel;
    public int maps = 1;
    bool tankused = false;
    public int pausebuttonn;
    public Toggle toggle;
    public Vector2 nitromovement = new Vector2(0, 100);
    void Start()
    {
        map_1 = setmap1;
        map_2 = setmap2;
        map_3 = setmap3;
        map_4 = setmap4;
        rb2d = GetComponent<Rigidbody2D>();
        maps = PlayerPrefs.GetInt("map");
        switch (maps)
        {
            case 1:
                map1load();
                break;
            case 2:
                map2load();
                break;
            case 3:
                map3load();
                break;
            case 4:
                map4load();
                break;
            default:
                map1load();
                break;
        }
        skin = PlayerPrefs.GetInt("skin");
        switch (skin)
        {
            case 0:
                spriterender.sprite = defaultcar;
                break;
            case 1:
                spriterender.sprite = blue;
                break;
            case 2:
                spriterender.sprite = white;
                break;
            case 3:
                spriterender.sprite = tank;
                tankused = true;
                break;
        }
        help = PlayerPrefs.GetInt("choose1");
        switch(help)
        {
            case 1:
                upgradeamp1 = 0.35f;
                break;
            case 2:
                upgradeamp1 = 0.45f;
                break;
            case 3:
                upgradeamp1 = 0.55f;
                break;
            case 4:
                upgradeamp1 = 0.6f;
                break;
            case 5:
                upgradeamp1 = 0.7f;
                break;
            case 6:
                upgradeamp1 = 0.8f;
                break;
            case 7:
                upgradeamp1 = 0.9f;
                break;
            case 8:
                upgradeamp1 = 1f;
                break;
            default:
                upgradeamp1 = 0.35f;
                break;
        }
        help = PlayerPrefs.GetInt("choose2");
        switch (help)
        {
            case 1:
                upgradeamp2 = 0.35f;
                rb2d.drag = 1.8f;
                drag = 1.8f;
                break;
            case 2:
                upgradeamp2 = 0.45f;
                rb2d.drag = 1.9f;
                drag = 1.9f;
                break;
            case 3:
                upgradeamp2 = 0.55f;
                rb2d.drag = 2f;
                drag = 2f;
                break;
            case 4:
                upgradeamp2 = 0.6f;
                rb2d.drag = 2.1f;
                drag = 2.1f;
                break;
            case 5:
                upgradeamp2 = 0.7f;
                rb2d.drag = 2.2f;
                drag = 2.2f;
                break;
            case 6:
                upgradeamp2 = 0.8f;
                rb2d.drag = 2.3f;
                drag = 2.3f;
                break;
            case 7:
                upgradeamp2 = 0.9f;
                rb2d.drag = 2.4f;
                drag = 2.4f;
                break;
            case 8:
                upgradeamp2 = 1f;
                rb2d.drag = 2.5f;
                drag = 2.4f;
                break;
            default:
                upgradeamp2 = 0.35f;
                rb2d.drag = 1.8f;
                drag = 1.8f;
                break;
        }
        help = PlayerPrefs.GetInt("choose3");
        switch (help)
        {
            case 1:
                upgradeamp3 = 0.35f;
                rb2d.angularDrag = 0.3f;
                drag = 0.3f;
                break;
            case 2:
                upgradeamp3 = 0.45f;
                rb2d.angularDrag = 0.45f;
                break;
            case 3:
                upgradeamp3 = 0.55f;
                rb2d.angularDrag = 0.55f;
                break;
            case 4:
                upgradeamp3 = 0.6f;
                rb2d.angularDrag = 0.6f;
                break;
            case 5:
                upgradeamp3 = 0.7f;
                rb2d.angularDrag = 0.7f;
                break;
            case 6:
                upgradeamp3 = 0.8f;
                rb2d.angularDrag = 0.8f;
                break;
            case 7:
                upgradeamp3 = 0.9f;
                rb2d.angularDrag = 0.9f;
                break;
            case 8:
                upgradeamp3 = 1f;
                rb2d.angularDrag = 1f;
                break;
            default:
                upgradeamp3 = 0.35f;
                rb2d.angularDrag = 0.35f;
                break;
        }
        if(tankused)
        {
            firebutton1.SetActive(true);
            firebutton2.SetActive(true);
        }
        else
        {
            firebutton1.SetActive(false);
            firebutton2.SetActive(false);
        }
    }
    void FixedUpdate()
    {
        movresult();
        Vector2 movement = new Vector2(0, movementsresult);
        RotationMove();
        //Debug.Log("movements: " + movements);
        //Debug.Log("speed: " + speed);
        //Debug.Log(vinputuse);
        //Debug.Log("amplifier: " + amplifier);
        //Debug.Log("movementsresult: " + movementsresult);
        //Debug.Log("rotation: " + rotation);
        //Debug.Log("rotationamp: " + rotationamp);
        //Debug.Log("rotationuse: " + rotationuse);
        //Debug.Log("rotationresult: " + rotationresult);
        rb2d.AddRelativeForce(movement * speed);
        rb2d.MoveRotation(rotationresult);
    }
    public void StartMoveVertical(float vinput)
    {
        vinputuse = true;
        movements = vinput;
    }
    public void vinputstop()
    {
        vinputuse = false;
    }
    public void movresult()
    {
        if (vinputuse && amplifier <= 2.5* upgradeamp1) { amplifier += 0.01f; }
        if (vinputuse == false && amplifier > 0) { amplifier -= 0.05f; }
        movementsresult = movements * amplifier * upgradeamp2;
    }
    public void StartRotation(float inputrotation)
    {
        rotation = inputrotation;
    }
    public void rotationused(bool a)
    {
        rotationuse = a;
    }
    void RotationMove()
    {
        if (rotationuse && rotationamp <= 10) rotationamp += 0.01f * amplifier + 0.01f;
        if (rotationuse == false && rotation == 0) rotationamp = 1;
        rotationresult += rotation * rotationamp;
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "grass")
        {
            //Debug.Log("GRASS");
            if (rb2d.drag < 7.5)
            {
                rb2d.drag += 0.5f;
            }
        }
        if (other.tag == "road")
        {
            if (rb2d.drag > drag)
            {
                rb2d.drag -= 0.5f;
            }
        }
    }
    public void nitroused()
    {
        for (int i = 0; i < 3; i++)
        {
            rb2d.AddRelativeForce(nitromovement * (speed * upgradeamp3));
            if(amplifier < 3) amplifier += 0.5f;
        }
    }
    public void map1load()
    {
        map_4.SetActive(false);
        map_3.SetActive(false);
        map_2.SetActive(false);
        map_1.SetActive(true);
        
    }
    public void map2load()
    {
        map_4.SetActive(false);
        map_3.SetActive(false);
        map_2.SetActive(true);
        map_1.SetActive(false);
    }
    public void map3load()
    {
        map_4.SetActive(false);
        map_3.SetActive(true);
        map_2.SetActive(false);
        map_1.SetActive(false);
    }
    public void map4load()
    {
        map_4.SetActive(true);
        map_3.SetActive(false);
        map_2.SetActive(false);
        map_1.SetActive(false);
    }
    public void fireon()
    {
        if (bulletavaible)
        {
            bulletavaible = false;
            bullet.SetActive(true);
            bullet.GetComponent<bullet>().startmovement();
            StartCoroutine(bulletcooldown());
        }
    }
    IEnumerator bulletcooldown()
    {
        yield return new WaitForSeconds(10);
        bulletavaible = true;
    }
    public void pausebtnon()
    {
        if (panel.activeSelf)
        {
            if (pausebuttonn == 0)
            {
                pausebuttonn = 1;
                Debug.Log("pausebuttonn 1");
                PlayerPrefs.SetInt("pausebtnoff", 1);
            }
            else if (pausebuttonn == 1)
            {
                pausebuttonn = 0;
                Debug.Log("pausebuttonn 0");
                PlayerPrefs.SetInt("pausebtnoff", 0);
            }
        }
    }
    public void pausebuttonsload()
    {
        pausebuttonn = PlayerPrefs.GetInt("pausebtnoff");
        switch (pausebuttonn)
        {
            case 0:
                Debug.Log("CASE 0");
                pausebuttons.SetActive(false);
                toggle.isOn = false;
                Debug.Log(pausebuttonn);
                break;
            case 1:
                Debug.Log("CASE 1");
                pausebuttons.SetActive(true);
                toggle.isOn = true;
                Debug.Log(pausebuttonn);
                break;
            default:
                Debug.Log("CASE DEFAULT");
                pausebuttons.SetActive(false);
                toggle.isOn = false;
                Debug.Log(pausebuttonn);
                break;
        }
    }
    private void Awake()
    {
        Debug.Log("AWAKE");
        pausebuttonsload();
    }
}
