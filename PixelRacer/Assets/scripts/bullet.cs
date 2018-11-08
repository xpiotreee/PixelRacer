using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour {
    public Rigidbody2D rb2d;
    public GameObject bulletobject;
    public Transform defaultpos;
    public Transform pos;
    public Vector2 movement = new Vector2(0, 3);
    void OnCollisionEnter2D(Collision2D collision)
    {
        pos.position = new Vector3(defaultpos.position.x, defaultpos.position.y, defaultpos.position.z);
        pos.transform.rotation = defaultpos.rotation;
        bulletobject.SetActive(false);
    }
    public void startmovement()
    {
        rb2d.AddRelativeForce(movement);
    }
}
