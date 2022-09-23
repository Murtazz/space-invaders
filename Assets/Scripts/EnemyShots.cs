using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShots : MonoBehaviour
{
      public int spd = -5; // speed of beam
    public int dmg; //Damage
    private string target;
    // Start is called before the first frame update
    void Start() 
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, spd);
    }

    private void OnBecameInvisible() {
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D other) {
        
        if (other.tag == "Player" && other.tag == "PlayerBeam") {
            Destroy(other.gameObject);  // kills other object if not player
            Destroy(gameObject);        // beam goes away
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
