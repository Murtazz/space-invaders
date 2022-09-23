using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    // Start is called before the first frame update
    public void DiffSelect() {
            SceneManager.LoadScene(1);
    }
    public void PlayEasy() {
            SceneManager.LoadScene(2);
    }
    public void PlayMedium() {
            SceneManager.LoadScene(3);
    }

    public void PlayHard() {
            SceneManager.LoadScene(4);
    }
    public void MainMenu() {
        SceneManager.LoadScene(0);
    }
}
