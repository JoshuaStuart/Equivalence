using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameCounter : MonoBehaviour
{
    public PlayerController player;

    [Header("Counters")]
    public int collectables = 0;
    public int maxCollectables = 3;
    public int platforms = 0;
    public int maxPlatforms = 5;

    [Header("Objects")]
    public GameObject collectableText;
    public GameObject platformText;
    public GameObject platformObject;

    public void Update()
    {
        collectableText.GetComponent<Text>().text = (collectables + "/" + maxCollectables);
        platformText.GetComponent<Text>().text = (platforms + "/" + maxPlatforms);
    }

    private void Start()
    {
        if (player.canCreate == true)
        {
            platformObject.SetActive(true);
        }
        else
        {
            platformObject.SetActive(false);
        }
    }
}
