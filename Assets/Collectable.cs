using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public GameCounter gc;

    public string itemType;
    public int collectableNumber;

    public PlayerController player;

    private void Start()
    {
        itemType = this.gameObject.name;
    }

    private void Awake()
    {
        if (player.collection.Contains(itemType) || PlayerPrefs.HasKey(itemType))
        {
            //the collectable has already been collected
            Destroy(gameObject);
        }
        else
        {
            //the collection does not have the itemType at the moment so therefore it has not been collected
        }
    }

    private void OnDestroy()
    {
        gc.collectables++;
    }
}
