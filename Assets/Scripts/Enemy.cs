using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;

    //if true then the enemy will move left to right otherwise it will go up and down rather than left to right
    public bool updownMovement;

    //public GameObject deathEffect;

    public void TakeDamage(int damage)
    {
        health -= damage;

        if(health <= 0)
        {
            Die();
        }     
    }

    void Die()
    {
        Destroy(gameObject);
    }

    //patrolling on platforms; from the following video - https://www.youtube.com/watch?v=aRxuKoJH9Y0&t=375s
    public int speed;
    private bool movingRight = true;
    public Transform groundDetection;

    private void Update()
    {
        if (updownMovement == false)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            RaycastHit2D groundinfo = Physics2D.Raycast(groundDetection.position, Vector2.down, 2f);
            RaycastHit2D groundinfol = Physics2D.Raycast(groundDetection.position, Vector2.left, .2f);
            RaycastHit2D groundinfor = Physics2D.Raycast(groundDetection.position, Vector2.right, .2f);
            if (((groundinfo.collider == false) || (groundinfol == true && groundinfol.collider.tag != "Player") || (groundinfor == true && groundinfor.collider.tag != "Player")) /*&& (groundinfol.collider.tag != "Player" && groundinfor.collider.tag != "Player")*/)
            {
                //the ray has not hit anything meaning there is no platform below the ground detection
                if (movingRight == true)
                {
                    movingRight = false;
                    transform.eulerAngles = new Vector3(0, -180, 0);
                }
                else
                {
                    movingRight = true;
                    transform.eulerAngles = new Vector3(0, 0, 0);
                }
            }
        }
        else
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
            RaycastHit2D groundinfo = Physics2D.Raycast(groundDetection.position, Vector2.down, 1f);
            RaycastHit2D groundinfol = Physics2D.Raycast(groundDetection.position, Vector2.left, .2f);
            RaycastHit2D groundinfor = Physics2D.Raycast(groundDetection.position, Vector2.right, .2f);
            if (((groundinfo.collider == false) || (groundinfol == true) || (groundinfor == true)) && (groundinfol.collider.tag != "Player" && groundinfor.collider.tag != "Player"))
            {
                //the ray has not hit anything meaning there is no platform below the ground detection
                if (movingRight == true)
                {
                    movingRight = false;
                    transform.eulerAngles = new Vector3(-180, 0, 0);
                }
                else
                {
                    movingRight = true;
                    transform.eulerAngles = new Vector3(0, 0, 0);
                }
            }
        }
    }
    //using a raycast to see if their is a platform in front

}
