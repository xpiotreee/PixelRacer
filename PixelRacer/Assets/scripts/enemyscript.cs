using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyscript : MonoBehaviour {
    public GameObject target;
    public GameObject bullet;
    public float moveSpeed;
    public float rotationSpeed;
    public int cooldown;
    public bool movement = true;
    void Start()
    {
        bullet.SetActive(false);
        StartCoroutine(bulletcooldown());
    }
    void Update () {
        if (movement)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, moveSpeed * Time.deltaTime);
            Vector3 vectorToTarget = target.transform.position - transform.position;
            float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg - 90;
            Quaternion qt = Quaternion.AngleAxis(angle, Vector3.forward);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, qt, Time.deltaTime * rotationSpeed);
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player") movement = false;
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        movement = true;
    }
    public void bulletoff()
    {
        bullet.SetActive(false);
        StartCoroutine(bulletcooldown());
    }
    IEnumerator bulletcooldown()
    {
        yield return new WaitForSeconds(cooldown);
        bullet.SetActive(true);
        bullet.GetComponent<bullet>().startmovement();
        
    }
}