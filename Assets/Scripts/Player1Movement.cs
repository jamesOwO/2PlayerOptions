using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Player1Movement : MonoBehaviour
{
    private Rigidbody2D rb;
    private float moveSpeed;
    private float movehorizontal;
    private float movevertical;
    public float jumpforce;
    private bool isjumping;
    public Animator animator;
    private BoxCollider2D coll;
    [SerializeField] private LayerMask jumpableGround;

    public float tpCooldown = 0;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
        moveSpeed = 3f;
        coll = GetComponent<BoxCollider2D>();
    }

    private void FixedUpdate()
    {
        movehorizontal = 0;
        // movement left and right
        if (Input.GetKey(KeyCode.D))
        {
            movehorizontal = 1;
        }
        else if (Input.GetKey(KeyCode.A)) 
        {
            movehorizontal = -1;
        }

        

        rb.velocity = new Vector2(movehorizontal * moveSpeed, rb.velocity.y);

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

    private void Update()
    {
        if (movehorizontal!= 0)
        {
            animator.SetBool("IsMoving", true);
        }
        else
        {
            animator.SetBool("IsMoving", false);

        }


        // jump
        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpforce);
            animator.SetBool("IsJumping", true);
        }

        // checks if touching ground
        IsGrounded();
        if (IsGrounded() == true)
        {
            animator.SetBool("IsJumping", false);
        }
        else
        {
            animator.SetBool("IsJumping", true);
        }

    }
    private bool IsGrounded()
    {
        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .01f, jumpableGround);
    }

}
