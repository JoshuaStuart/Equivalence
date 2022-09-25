using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    //keeping track of what has been collected, use in player script
    public List<string> collection;
    //set a new version on the start function of the player script alongside the above code

    public string itemType;

    public string narrative;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        //should be in the player script
        if (collision.CompareTag("Player")) //set this to collectable if used in player script
        {
            //string itemType = collision.gameObject.GetComponent<Collectable>().itemType;

            //add something for the story to be told/narrative to be shown such as a visual ntoe, etc...

            Destroy(gameObject); //modify to collision.gameObject if used in player script
        }
    }
}
