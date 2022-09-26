using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;

    public float jumpForce;
    private float moveInput;

    public bool canGlide = true;
    public float glidingSpeed;

    private float initalGravityScale;

    private Rigidbody2D rb;

    private bool facingRight = true;

    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;

    private int extraJumps;
    public int extraJumpsValue;

    private Animator anim;

    //keeping track of what has been collected, use in player script
    public List<string> collection;

    private void Start()
    {
        collection = new List<string>();
        extraJumps = extraJumpsValue;
        rb = GetComponent<Rigidbody2D>();
        initalGravityScale = rb.gravityScale;
        anim = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);

        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        if(facingRight == false && moveInput > 0)
        {
            Flip();
        }
        else if(facingRight == true && moveInput <0)
        {
            Flip();
        }

        if(moveInput == 0)
        {
            anim.SetBool("isRunning", false);
        }
        else
        {
            anim.SetBool("isRunning", true);
        }
    }

    void Update()
    { 
        if(isGrounded == true)
        {
            extraJumps = extraJumpsValue;
            anim.SetBool("isJumpimg", true);

        }
        else
        {
            anim.SetBool("isJumpimg", false);

        }

        if (Input.GetKeyDown(KeyCode.Space) && extraJumps > 0)
        {
            anim.SetTrigger("takeOff");
            rb.velocity = Vector2.up * jumpForce;
            GetComponent<AudioSource>().Play();
            extraJumps--;
        }
        else if(Input.GetKeyDown(KeyCode.Space) && extraJumps == 0 && isGrounded == true)
        {
            rb.velocity = Vector2.up * jumpForce;
            GetComponent<AudioSource>().Play();
        }
        if(canGlide == true)
        {
            if (Input.GetKey(KeyCode.Space) && rb.velocity.y <= 0)
            {
                rb.gravityScale = 0;
                rb.velocity = new Vector2(rb.velocity.x, glidingSpeed);
            }
            else
            {
                rb.gravityScale = initalGravityScale;
            }
        }
           
        
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Collectable"))
        {
            Debug.Log("collectable hit");

            string itemType = collision.gameObject.GetComponent<Collectable>().itemType;

            //need to use playerprefs to keep the list intact in order to not lose those already collected
            PlayerPrefs.SetString(itemType, itemType);

            collection.Add(itemType);


            Destroy(collision.gameObject);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        
    }
}
