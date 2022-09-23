using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HighScore : MonoBehaviour
{
    public Text scoreTxt;
    public Text highscoreTxt;
    int curscore = Score.score;
    int hscore = Score.highscore;

    // Start is called before the first frame update
    private void LateUpdate() {
    scoreTxt.text = "Score: " + curscore.ToString();
    highscoreTxt.text = "High Score: " + hscore.ToString();
    }
}
