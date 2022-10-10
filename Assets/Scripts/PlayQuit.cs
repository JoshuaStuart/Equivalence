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

    /* //better worded functions for swapping to the correct level scene
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

    public void LoadLeve7_A()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(14);
    }

    public void LoadLeve7_B()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(15);
    }

    public void LoadLeve8_A()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(16);
    }

    public void LoadLeve8_B()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(17);
    }

    public void LoadLeve9_A()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(18);
    }

    public void LoadLeve9_B()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(19);
    }

    public void LoadLeve10_A()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(20);
    }

    public void LoadLeve10_B()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(21);
    }
     */

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

    public void JoshTest1()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(8);
    }

    public void JoshTest2()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(9);
    }
}
