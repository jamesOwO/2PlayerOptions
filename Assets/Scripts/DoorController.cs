using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public GameObject door; 
    bool openDoor = false;
    public int bottomheight;
    public int topheight;
    public float speed;
    public Animator animator;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (openDoor == false)
        {
            if (door.transform.position.y <= topheight)
            {
                door.transform.position += transform.up * speed * Time.deltaTime;
            }
        }
        else
        {
            if (door.transform.position.y >= bottomheight)
            {
                door.transform.position += -transform.up * speed * Time.deltaTime;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Button ON");
        if (collision.tag == "Player1" || collision.tag == "Player2" || collision.tag == "Box")
        {
            openDoor = true;
            animator.SetBool("ButtonOn", true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player1" || collision.tag == "Player2" || collision.tag == "Box")
        {
            openDoor = false;
            animator.SetBool("ButtonOn", false);

        }
    }

}
