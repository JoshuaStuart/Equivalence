using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayQuit : MonoBehaviour
{
    public void LoadLevelSelect()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ReturnToMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

    public void LoadLevel1A()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(2);
    }

    public void LoadLevel1B()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(3);
    }

    public void LoadLevel3()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(4);
    }
}
