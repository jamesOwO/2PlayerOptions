using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Player2Movement : MonoBehaviour
{
    private Rigidbody2D rb;
    private float moveSpeed;
    private float movehorizontal;
    private float movevertical;
    //public Animator animator;
    private BoxCollider2D coll;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        moveSpeed = 4f;
        coll = GetComponent<BoxCollider2D>();
    }

    private void FixedUpdate()
    {
        movevertical = 0;
        movehorizontal = 0;
        // movement left and right
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            movehorizontal = -1;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            movehorizontal = 1;
        }
        if (Input .GetKey(KeyCode.DownArrow))
        {
            movevertical= -1;
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            movevertical= 1;
        }


        rb.velocity = new Vector2(movehorizontal * moveSpeed, movevertical * moveSpeed);

        // faces direction of movement
        if (movehorizontal > 0.1)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }
        if (movehorizontal < -0.1)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Pickup")
        {
        }
    }
}
