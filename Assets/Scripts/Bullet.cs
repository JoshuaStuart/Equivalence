using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;

    public PlayerController pc;

    public bool facingRight = true;

    private void Awake()
    {
        pc = FindObjectOfType<PlayerController>();
    }

    void Start()
    {
        //change the transofrm based on which wya th eplayer is going
        if (pc.facingRight == true)
        {
            rb.velocity = transform.right * speed;
        }
        else
        {
            rb.velocity = (transform.right * -1) * speed;
        }
    }

    private void FixedUpdate()
    {
        if (facingRight == false)
        {
            Flip();
        }
        else if (facingRight == true)
        {
            Flip();
        }
    }

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.tag != "Enemy")
        {
            //dont destroy
        }
        else
        {
            Enemy enemy = hitInfo.GetComponent<Enemy>();
            if (enemy != null)
            {
                enemy.TakeDamage(50);
            }
            Destroy(gameObject);
        }

    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }
}
