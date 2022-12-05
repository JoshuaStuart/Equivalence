using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityManager : MonoBehaviour
{
    public bool building;
    public bool shooting;
    public bool gliding;

    private void Start()
    {
        DontDestroyOnLoad(this);
    }
}
