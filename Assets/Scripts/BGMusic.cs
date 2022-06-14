using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMusic : MonoBehaviour
{
    public static BGMusic MusicInstance;

    private void Awake()
    {
        if (MusicInstance != null && MusicInstance != this)
        {
            Destroy(this.gameObject);
            return;
        }

        DontDestroyOnLoad(this.gameObject);

        MusicInstance = this;
    }
}
