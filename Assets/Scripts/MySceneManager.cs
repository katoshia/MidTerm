// created by Katoshia Grubb

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public static class MySceneManager
{
    // Start is called before the first frame update
    private static string lastScene;
    public static void setLastScene(string scene)
    {
        lastScene = scene;
    }
    public static string getLastScene()
    {
        return lastScene;
    }
    public static void changeToPrevisousScene()
    {
        SceneManager.LoadScene(lastScene);
    }
}
