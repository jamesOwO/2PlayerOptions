using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.SceneManagement;

public class Player2Movement : MonoBehaviour
{
    private Rigidbody2D rb;
    private float moveSpeed;
    private float movehorizontal;
    private float movevertical;
    //public Animator animator;
    private BoxCollider2D coll;
    private bool facingRight = true;


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
        if (movehorizontal > 0.1 && !facingRight)
        {
            flip();
        }
        if (movehorizontal < -0.1 && facingRight)
        {
            flip();
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(0);

        }

    }

    private void flip()
    {
        Vector3 currentScale = gameObject.transform.localScale;
        currentScale.x *= -1;
        gameObject.transform.localScale = currentScale;

        facingRight = !facingRight;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Water" || collision.gameObject.tag == "Projectile")
        {
            SceneManager.LoadScene(0);

        }

    }
}
