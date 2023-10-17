using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public Player1Movement player1Movement;
    public GameObject otherTp;
    void Start()
    {
        player1Movement.tpCooldown = 0;

    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player1")
        {

            if (Time.time >= player1Movement.tpCooldown)
            {
                collision.transform.position = new Vector2(otherTp.transform.position.x, otherTp.transform.position.y);
                player1Movement.tpCooldown = Time.time + 0.5f;
            }
        }
    }
}
