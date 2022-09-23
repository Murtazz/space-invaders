using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    public static int score;
    public static int highscore;
    private int set;
    public Text scoreTxt; 
    void Start() {
        score = 0;
        if (PlayerDifficulty.diff == "Easy") {
            highscore = PlayerPrefs.GetInt("EHighscore", 0);
            set = 0;
        } else if (PlayerDifficulty.diff == "Medium") {
            highscore = PlayerPrefs.GetInt("MHighscore", 0);
            set = 1;
        } else if (PlayerDifficulty.diff == "Hard") {
            highscore = PlayerPrefs.GetInt("HHighscore", 0);
            set = 2;        
        }
    }
    public static void updateScore(int increase) {
        score += increase;
    }
    // Update is called once per frame
    void LateUpdate()
    {
        scoreTxt.text = "Score: " + score;
        if (score >= highscore) {
            if (set == 0) {
                PlayerPrefs.SetInt("EHighscore", score);
                highscore = PlayerPrefs.GetInt("EHighscore", 0);
            } else if (set == 1) {
                PlayerPrefs.SetInt("MHighscore", score);
                highscore = PlayerPrefs.GetInt("MHighscore", 0);
            } else if (set == 2) {
                PlayerPrefs.SetInt("HHighscore", score);
                highscore = PlayerPrefs.GetInt("HHighscore", 0);
            }
        }
    }
}
