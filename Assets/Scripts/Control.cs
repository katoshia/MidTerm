using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Control : MonoBehaviour
{

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

    
}
