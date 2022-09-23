using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Shot : MonoBehaviour
{
    
    public int spd = 5; // speed of beam
    public int dmg; //Damage
    public string target;
    public GameObject explosion;
    // Start is called before the first frame update
    void Start() 
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, spd);
    }

    void OnBecameInvisible() {
        Destroy(gameObject);
    }
    void OnTriggerEnter2D(Collider2D other) {
        
        if (other.tag == target || other.tag == "PlayerBeam") {
            if (target == "Enemy") {
                Score.updateScore(100);
            }
            
            Destroy(other.gameObject);  // kills other object if not player
            GameObject fire = (GameObject) Instantiate(explosion, other.gameObject.transform.position, Quaternion.identity);
            Destroy(fire, 0.4f);
            Destroy(gameObject);        // beam goes away
            if (other.tag == "Player") {
                if (PlayerDifficulty.diff == "Easy") {
                    SceneManager.LoadScene(5);
                } else if (PlayerDifficulty.diff == "Medium") {
                    SceneManager.LoadScene(6);
                } else if (PlayerDifficulty.diff == "Hard") {
                    SceneManager.LoadScene(7);
                }
            }
        }
    }
    
    // Update is called once per frame
    void Update() 
    {
        
    }
}
