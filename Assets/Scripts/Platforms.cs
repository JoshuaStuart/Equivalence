using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platforms : MonoBehaviour
{
    public float timeRemaining;

    public void Awake()
    {
        timeRemaining = 5;
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
}
