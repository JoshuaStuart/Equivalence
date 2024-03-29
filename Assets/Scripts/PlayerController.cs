using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public AbilityManager am;

    [Header("Movement")]
    public float speed;

    public float jumpForce;
    private float moveInput;

    public bool canGlide = true;
    public float glidingSpeed;

    private float initalGravityScale;

    private Rigidbody2D rb;

    public bool facingRight = true;

    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;

    private int extraJumps;
    public int extraJumpsValue;

    private Animator anim;

    //keeping track of what has been collected, use in player script
    public List<int> collection;

    [Header("Platform Creation")]
    //setting up details for creating platforms whilst jumping
    public GameObject newPlatform;
    public bool canCreate;
    public GameObject currentPlatform;
    public int maxPlatforms;
    public int usedPlatforms = 0;

    [Header("UI Variables")]
    public GameObject pauseMenu;

    private void Start()
    {
        collection = new List<int>();
        extraJumps = extraJumpsValue;
        rb = GetComponent<Rigidbody2D>();
        initalGravityScale = rb.gravityScale;
        anim = GetComponent<Animator>();

        playerAbilities();
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

        //creating platforms in game
        if (canCreate == true && isGrounded == false)
        {
            if (currentPlatform == null)
            {
                //the character is able to not only create platforms but is also not in the air
                float distance = 1f;

                RaycastHit2D groundinfo = Physics2D.Raycast(this.transform.position, Vector2.down, distance);
                Debug.Log(groundinfo);

                Debug.Log(groundinfo.collider);

                //the player must use a button possibly a mouse click as this will be on the ice character as the fire will be able to shoot
                if ((Input.GetMouseButtonDown(1) && groundinfo.collider.tag != "ground" && (usedPlatforms <= maxPlatforms))/* add in a part to allow a set amount of paltforms created */)
                {
                    usedPlatforms++;
                    currentPlatform = Instantiate(newPlatform);
                    currentPlatform.transform.position = new Vector2(this.transform.position.x, (this.transform.position.y - distance));
                }
            }
        }

        if (Input.GetKey(KeyCode.Escape))
        {
            //pause menu
            Time.timeScale = 0; ;
            pauseMenu.SetActive(true);

            //reverse the code above for exiting the pausemenu
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

            int itemType = collision.gameObject.GetComponent<Collectable>().collectableNumber;

            //need to use playerprefs to keep the list intact in order to not lose those already collected
            //PlayerPrefs.SetString(itemType, itemType);

            collection.Add(itemType);


            Destroy(collision.gameObject);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        
    }

    public void playerAbilities()
    {
        canCreate = am.building;
        canGlide = am.gliding;
        //am.shooting;
    }
}
