using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LillypadControl : MonoBehaviour
{
    private float time;

    public bool directionRight;
    public float speed;

    public float distanceLeft;
    public float distanceRight;

    void Start()
    {
        time = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.x >= distanceRight)
        {
            directionRight = false;
        }
        else if (this.transform.position.x <= distanceLeft)
        {
            directionRight = true;
        }
        if (directionRight )
        {
            this.transform.position += transform.right * speed * Time.deltaTime;
        }
        if (!directionRight )
        {
            this.transform.position += -transform.right * speed * Time.deltaTime;
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player1")
        {
            if (directionRight)
            {
                collision.transform.position += transform.right * speed * Time.deltaTime;
            }
            if (!directionRight)
            {
                collision.transform.position += -transform.right * speed * Time.deltaTime;
            }

        }

    }
}
