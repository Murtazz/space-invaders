using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame() {
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

    public void QuitGame1() {
        Application.Quit();
    }
}
