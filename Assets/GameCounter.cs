using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameCounter : MonoBehaviour
{
    [Header("Counters")]
    public int collectables = 0;
    public int maxCollectables = 3;
    public int platforms = 0;
    public int maxPlatforms = 5;

    [Header("Objects")]
    public GameObject collectableText;
    public GameObject platformText;

    public void Update()
    {
        collectableText.GetComponent<Text>().text = (collectables + "/" + maxCollectables);
        platformText.GetComponent<Text>().text = (platforms + "/" + maxPlatforms);
    }
}
