using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScenes : MonoBehaviour
{

    public void LoadLevel(string SceneName)
    {
        Debug.Log("Level load requested for: " + SceneName);
        SceneManager.LoadScene(SceneName);
    }

    public void QuitRequest()
    {
        Debug.Log("Requested to quit.");
        Application.Quit();
    }
}