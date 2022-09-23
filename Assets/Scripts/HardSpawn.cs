using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardSpawn : MonoBehaviour
{
    public GameObject Enemy;
    private float randomizedInterval;
    private int randomizedMove;
    private float counter = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        randomizedInterval = 105f;
        randomizedMove = Random.Range(-11, 11);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Time.time > 300) {
            randomizedInterval = 70f;
        } else if (Time.time > 200) {
            randomizedInterval = 85f;
        } else if (Time.time > 100) {
            randomizedInterval = 95f;
        }
        
        counter += 1;
        if (counter >= randomizedInterval) {
            counter = 0;
            Instantiate(Enemy, transform.position, transform.rotation);
            transform.position = new Vector2(randomizedMove, transform.position.y);
            randomizedMove = Random.Range(-11, 11);
        }
    }
}
