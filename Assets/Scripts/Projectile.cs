using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    // Start is called before the first frame update
    public float downspeed;
    public float leftspeed;
    private float start;
    void Start()
    {
        start = Time.time;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        this.transform.position += -transform.right * leftspeed;
        this.transform.position += -transform.up * downspeed;
        if (start + 10f <= Time.time)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player11" || other.gameObject.tag == "Border" || other.gameObject.tag == "Player2")
        {
            Destroy(this.gameObject);
        }
    }

}
