using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrappleHook : MonoBehaviour
{
    LineRenderer line;

    [SerializeField] LayerMask grappleableMask;
    [SerializeField] float maxDistance = 10f;
    [SerializeField] float grappleSpeed = 10f;
    [SerializeField] float grappleShootSpeed = 10f;

    bool isGrappling = false;
    [HideInInspector] public bool retracting = false;

    Vector2 target;

    private Rigidbody2D rb;
    private Animator anim;

    private void Start()
    {
        line = GetComponent<LineRenderer>();
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0) && !isGrappling)
        {
            StartGrapple();
            anim.SetBool("grappling", true);
        }

        if (retracting)
        {
            Vector2 grapplePos = Vector2.Lerp(transform.position, target, grappleSpeed * Time.deltaTime);

            transform.position = grapplePos;

            line.SetPosition(0, transform.position);

            if(Vector2.Distance(transform.position, target) < 0.5f)
            {
                retracting = false;
                isGrappling = false;
                line.enabled = false;
                rb.gravityScale = 1;
            }
        }

        anim.SetBool("grappling", false);

    }

    private void StartGrapple()
    {
        Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;

        RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, maxDistance, grappleableMask);

        if(hit.collider != null)
        {
            rb.gravityScale = 0;
            rb.velocity = Vector2.zero;
            isGrappling = true;
            target = hit.point;
            line.enabled = true;
            line.positionCount = 2;

            StartCoroutine(Grapple());
        }
    }

    IEnumerator Grapple()
    {
        float t = 0;
        float time = 10;
        line.SetPosition(0, transform.position);
        line.SetPosition(1, transform.position);

        Vector2 newPos;

        if(rb.velocity.y >= 0)
        {
            for (; t < time; t += grappleShootSpeed * Time.deltaTime)
            {
                newPos = Vector2.Lerp(transform.position, target, t / time);
                line.SetPosition(0, transform.position);
                line.SetPosition(1, newPos);

                yield return null;
                
            }
        }
        else
        {
            yield return null;
        }
            

        line.SetPosition(1, target);
        retracting = true;
    }
}
