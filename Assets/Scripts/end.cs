using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class end : MonoBehaviour
{
    public int fini = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (fini >= 2)
        {
            SceneManager.LoadScene(1);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player1" || collision.gameObject.tag == "Player2")
        {
            Destroy(collision.gameObject);
            fini++;
        }
    }
}
