using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    private float fireRate = 0.45f;
    private float nextFire = 1;
    public GameObject shot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
        GetComponent<Rigidbody2D>().velocity = new Vector2(Input.GetAxis("Horizontal") * 10, Input.GetAxis("Vertical") * 10);
        if (Time.time > 300) {
            fireRate = 0.3f;
        } else if (Time.time > 200) {
            fireRate = 0.35f;
        } else if (Time.time > 200) {
            fireRate = 0.4f;
        }
        if (Input.GetButton("Fire1") && Time.time > nextFire && fireRate > 0) {
            nextFire = Time.time + fireRate;
            Instantiate(shot, transform.position, Quaternion.identity);
        }
    }
    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "WallL") {
            transform.position = new Vector2(transform.position.x + 0.4f, transform.position.y);
        } else if (other.tag == "WallR") {
            transform.position = new Vector2(transform.position.x - 0.4f, transform.position.y);
        } else if (other.tag == "WallU") {
            transform.position = new Vector2(transform.position.x, transform.position.y - 0.4f);
        } else if (other.tag == "WallD") {
            transform.position = new Vector2(transform.position.x, transform.position.y + 0.4f);
        }
    }
}
