using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public GameObject player;
    public GameObject shield;
    private bool activeShield;
    private Vector3 position;
    private Animator anim;

    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    private Vector2 movement;

    void Start()
    {
        //Set Deflect animation & active shield to false when starting game.
        anim = GetComponent<Animator>();

        activeShield = false;
        shield.SetActive(false);
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        // Toggle Shield w/ Left Ctrl
        if (Input.GetKey(KeyCode.LeftControl))
        {
            if (!activeShield)
            {
                moveSpeed = 0f;

                anim.SetBool("Running", false);
                anim.SetBool("Deflect", true);
                shield.SetActive(true);
                activeShield = true;
            }
            
            else
            {
                moveSpeed = 5f;

                anim.SetBool("Deflect", false);
                anim.SetBool("Running", true);
                shield.SetActive(false);
                activeShield = false;
            }
        }

        // Flip player sprite
        Vector3 characterScale = transform.localScale;

        if (movement.x < 0)
        {
            characterScale.x = -2.5f;
        }
        if (movement.x > 0)
        {
            characterScale.x = 2.5f;
        }

        transform.localScale = characterScale;
        
            // Quit Game
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

       /* if (movement.x == 0f || movement.y == 0f)
        {
            //Put idle animation here!!!
        }*/
    }
        // Player gets Knocked back
        private void OnTriggerEnter2D(Collider2D other)
        {
            if(other.tag == "Projectile")
            {
                anim.SetTrigger("Hit");
                Vector2 difference = transform.position - other.transform.position;
                transform.position = new Vector2(transform.position.x + difference.x * 5, transform.position.y + difference.y);
            }

            Destroy(GameObject.FindWithTag("Projectile"));
        
        }

    public bool ActiveShield
    {
        get
        {
            return activeShield;
        }
        set
        {
            activeShield = value;
        }
    }
}
