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

    //new load levels done for blake and connor's levels

    public void BlakeA()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(4);
    }

    public void BlakeB()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(5);
    }

    public void ConnorA()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(6);
    }

    public void ConnorB()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(7);
    }
}
