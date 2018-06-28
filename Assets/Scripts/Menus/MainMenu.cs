using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

    [SerializeField]
    private Transform creditText;

    [SerializeField]
    private GameObject mainMenu, creditsMenu, creditsText;

    public void PlayGame()
    {
        SceneManager.LoadScene(2);
    }

    public void Credits()
    {
        creditsMenu.SetActive(true);
        mainMenu.SetActive(false);
    }

    public void Back()
    {
        creditsMenu.SetActive(false);
        mainMenu.SetActive(true);

    }

    public void Quit()
    {
        Application.Quit();
    }
}
