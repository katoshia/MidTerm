using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Control : MonoBehaviour
{
   
    // go to main menu from start up screen.
    public void MainSceen()
    {
        SceneManager.LoadScene("MainMenu");
    }
    // End Gamme from Main Menu (back to Startup Screen)
    public void EndGame()
    {
        SceneManager.LoadScene("StartUpScreen");
    }
    // go to game screen for new game.
    public void StartGame()
    {
        SceneManager.LoadScene("GameScreen");
    }
    // go to options menu from either main menu or game play screen.
    public void OptionsMenu()
    {
        SceneManager.LoadScene("OptionsScreen");
    }
    // place holder for load current game location and sedttings 
    public void LoadGame() { }
    
}
