using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuScript : MonoBehaviour
{
    public void OnPlayButton()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void OnQuitButton()
    {
        Application.Quit();
    }

    public void OnMenuButton()
    {
        print("boop");
        SceneManager.LoadScene("Main_Menu");
    }
}