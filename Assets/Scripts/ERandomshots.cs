using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ERandomshots : MonoBehaviour
{
    public float timeBetweenShots;
    public float nextShot = -1;
    public GameObject bullet;


    // Start is called before the first frame update
    void Start()
    {
        nextShot = Random.Range(1, 4.0f);
        timeBetweenShots = Random.Range(3, 7.5f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextShot) {
            Instantiate(bullet, transform.position, Quaternion.identity);
            nextShot = Time.time + timeBetweenShots;
        }
    }
}
