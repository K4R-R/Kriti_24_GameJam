using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    /*public void PlayGame()
    {
        SceneManager.LoadScene("Level_1");
    }*/
    public void PlayGame()
    {
        SceneManager.LoadScene("NewLevel1");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
