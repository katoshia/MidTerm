using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Control : MonoBehaviour
{
    public void MainSceen()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void EndGame()
    {
        SceneManager.LoadScene("StartUpScreen");
    }
    public void StartGame()
    {
        SceneManager.LoadScene("GameScreen");
    }
    public void OptionsMenu()
    {
        SceneManager.LoadScene("OptionsScreen");
    }
}
