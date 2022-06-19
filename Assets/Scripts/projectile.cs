using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{
    public float speed = 5.0f;
    private Rigidbody2D rb;   
    private Vector2 endScreen;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-speed, 0);
        endScreen = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.width, Camera.main.transform.position.z));
    }

    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Shield")
        {
             this.rb.velocity = new Vector2(speed, 0);
             this.GetComponent<BoxCollider2D>().enabled = false;
        }
    }
}
