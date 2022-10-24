using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platforms : MonoBehaviour
{
    public float timeRemaining;

    private void Update()
    {
        timeRemaining--;

        if (timeRemaining <= 0)
        {
            Destroy(this);
        }
    }
}
