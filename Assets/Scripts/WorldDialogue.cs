using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldDialogue : MonoBehaviour
{
    public Transform dialogueBox;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            dialogueBox.gameObject.SetActive(true);
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            dialogueBox.gameObject.SetActive(false);
        }
    }
}
