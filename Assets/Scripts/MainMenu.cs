using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject levelLoader;

    public void playGame () {
        levelLoader.GetComponent<LevelLoaderScript>().LoadNextLevel("Dialogue");
    }

    public void QuitGame () {
        Application.Quit();
    }
}
