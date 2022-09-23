using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ESpawner2 : MonoBehaviour
{
    public GameObject Enemy2;
    public float randomizedInterval2;
    private string Difficulty2;
    public int randomizedMove2;
    private float counter2 = 0;

    // Start is called before the first frame update
    void Start()
    {
        randomizedInterval2 = 130f;
        randomizedMove2 = Random.Range(1, 11);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Time.time > 300) {
            randomizedInterval2 = 90f;
        } else if (Time.time > 200) {
            randomizedInterval2 = 100f;
        } else if (Time.time > 100) {
            randomizedInterval2 = 115f;
        }
        
        counter2 += 1;
        if (counter2 >= randomizedInterval2) {
            counter2 = 0;
            Instantiate(Enemy2, transform.position, transform.rotation);
            transform.position = new Vector2(randomizedMove2, transform.position.y);
            randomizedMove2 = Random.Range(1, 11);
        }
    }
}
