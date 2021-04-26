// created by Katoshia Grubb

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Control : MonoBehaviour
{
    // used to load new scenes and save previsous screen for proper return from options menu.
    public void LoadScene(string newScene)
    {
        SceneManager.LoadScene(newScene);
        MySceneManager.setLastScene(SceneManager.GetActiveScene().name);
    }

    // place holder for load current game location and sedttings 
    public void LoadGame() { }

    // for return from options menu. 
    public void PreviousScene()
    {
        MySceneManager.getLastScene();
        MySceneManager.changeToPrevisousScene();
    }

    // used to update text for game based on click events through game progression

     
    public void UpdateText()
    {
        Text _textChange = Text.Find("StoryText");
        _textChange = Text.print();
        
    }

    
}
