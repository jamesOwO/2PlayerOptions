using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftController : MonoBehaviour
{
    public int bottomheight;
    public int topheight;
    public GameObject lift;
    public float speed;
    private bool liftup = false;
    private void Update()
    {
        if (liftup == true)
        {
            if (lift.transform.position.y <= topheight)
            {
                lift.transform.position += transform.up * speed * Time.deltaTime;
            }
        }
        else if (liftup == false)
        {
            if (lift.transform.position.y >= bottomheight)
            {
                lift.transform.position += -transform.up * speed * Time.deltaTime;
            }
        }
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player1")
        {
            Debug.Log("up");
            liftup = true;
        }

    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player1")
        {
            Debug.Log("Down");
            liftup = false;
        }
    }
}
