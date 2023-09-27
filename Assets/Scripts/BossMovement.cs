using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossMovement : MonoBehaviour
{
    [SerializeField]
    private float rayDistance;

    [SerializeField]
    private float speed = 4f;
    
    [SerializeField]
    private Transform raycastPoint;

    private Vector2 direction = Vector2.right;
    private Transform player;
    private Rigidbody2D rb;
    private Animator animator;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(
            transform.position,
            direction,
            3f
        );

        Debug.DrawRay(
            transform.position,
            transform.right * 3f,
            Color.red
        );

        if (hit)
        {
            player = hit.collider.transform;
            Attack();
        }
        else
        {
            animator.SetBool("IsRunning", false);
        }

        if(ShouldFall())
        {
            rb.velocity = new Vector2(
                0f,
                rb.velocity.x
            );
        }
    }
    
    private bool ShouldFall()
    {
        Vector2 dir = new Vector2(1f,-1f);

        RaycastHit2D hit = Physics2D.Raycast(
            raycastPoint.position,
            dir.normalized,
            2f
        );

        Debug.DrawRay(
            raycastPoint.position,
            dir.normalized * 2f,
            Color.blue
        );

        if(hit)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    private void Attack()
    {
        rb.velocity = new Vector2(
            speed,
            rb.velocity.y
        );
        animator.SetBool("IsRunning", true);
    }
}
