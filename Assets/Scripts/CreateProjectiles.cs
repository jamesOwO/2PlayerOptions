using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateProjectiles : MonoBehaviour
{
    public GameObject spawner1, spawner2, spawner3, spawner4, spawner5, spawner6, spawner7, spawner8, spawner9, spawner10, spawner11, spawner12;
    public GameObject projectile1, projectile2, projectile3, projectile4;
    private float counter;
    private int num;
    // Start is called before the first frame update
    void Start()
    {
        counter = Time.time + 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (counter <= Time.time)
        {
            num = Random.Range(1, 13);

            switch (num)
            {
                case 1:
                    SpawnProjectile(spawner1);
                    break;
                case 2:
                    SpawnProjectile(spawner2);
                    break;
                case 3:
                    SpawnProjectile(spawner3);
                    break;
                case 4:
                    SpawnProjectile(spawner4);
                    break;
                case 5:
                    SpawnProjectile(spawner5);
                    break;
                case 6:
                    SpawnProjectile(spawner6);
                    break;
                case 7:
                    SpawnProjectile(spawner7);
                    break;
                case 8:
                    SpawnProjectile(spawner8);
                    break;
                case 9:
                    SpawnProjectile(spawner9);
                    break;
                case 10:
                    SpawnProjectile(spawner10);
                    break;
                case 11:
                    SpawnProjectile(spawner11);
                    break;
                case 12:
                    SpawnProjectile(spawner12);
                    break;


            }
            counter = Time.time + 0.2f;
        }

    }
    public void SpawnProjectile(GameObject gameObject)
    {
        num = Random.Range(1, 5);
        switch (num)
        {
            case 1:
                Instantiate(projectile1, gameObject.transform.position, transform.rotation);
                break;
            case 2:
                Instantiate(projectile2, gameObject.transform.position, transform.rotation);
                break ;
            case 3:
                Instantiate(projectile3, gameObject.transform.position, transform.rotation);
                break;
            case 4:
                Instantiate(projectile4, gameObject.transform.position, transform.rotation);
                break;
        }
    }
}
