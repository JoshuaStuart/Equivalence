using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScript : MonoBehaviour
{
    public Transform gameOverCanvas;

    private void Awake()
    {
        gameOverCanvas.gameObject.SetActive(false);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Time.timeScale = 0;
            gameOverCanvas.gameObject.SetActive(true);
        }
    }
}
