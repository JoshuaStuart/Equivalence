using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayQuit : MonoBehaviour
{
    //public AbilityManager am;
    //public PlayerController pc;

    //private void Awake()
    //{
    //    am = FindObjectOfType<AbilityManager>();
    //}

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

    public void LoadLevel1_A()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(2);
    }

    public void LoadLevel1_B()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(3);
    }

    public void LoadLeve2_A()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(4);
    }

    public void LoadLeve2_B()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(5);
    }
    public void LoadLeve3_A()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(6);
    }

    public void LoadLeve3_B()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(7);
    }

    public void LoadLeve4_A()
    {
        //am.building = pc.canCreate;
        Time.timeScale = 1;
        SceneManager.LoadScene(8);
    }

    public void LoadLeve4_B()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(9);
    }

    public void LoadLeve5_A()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(10);
    }

    public void LoadLeve5_B()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(11);
    }

    public void LoadLeve6_A()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(12);
    }

    public void LoadLeve6_B()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(13);
    }

}
