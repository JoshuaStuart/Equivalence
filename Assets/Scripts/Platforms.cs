using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platforms : MonoBehaviour
{
    public GameCounter gc;
    public float timeRemaining;


    public void Awake()
    {
        gc = FindObjectOfType<GameCounter>();

        timeRemaining = 2;

    }
    private void Update()
    {
        timeRemaining -= Time.deltaTime;

        Debug.Log(timeRemaining);

        if (timeRemaining < 1)
        {
            Destroy(this.gameObject);
        }

    }

    private void OnDestroy()
    {
        gc.platforms++;
    }
}
