using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ESpawner : MonoBehaviour
{
    public GameObject Enemy;
    public static string Difficulty; 
    private float randomizedInterval;
    private int randomizedMove;
    private float counter = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        randomizedInterval = 130f;
        randomizedMove = Random.Range(-11, -1);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Time.time > 300) {
            randomizedInterval = 90f;
        } else if (Time.time > 200) {
            randomizedInterval = 100f;
        } else if (Time.time > 100) {
            randomizedInterval = 115f;
        }
        
        counter += 1;
        if (counter >= randomizedInterval) {
            counter = 0;
            Instantiate(Enemy, transform.position, transform.rotation);
            transform.position = new Vector2(randomizedMove, transform.position.y);
            randomizedMove = Random.Range(-11, -1);
        }
    }
}
