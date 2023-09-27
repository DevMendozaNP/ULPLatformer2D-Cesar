using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossLogic : MonoBehaviour
{
    [SerializeField]
    float moveSpeed;
    private float moveDirection = 1f;
    private bool facingRight = true;
    [SerializeField]
    Transform groundCheckPoint;
    [SerializeField]
    Transform wallCheckPoint;
    [SerializeField]
    float circleRadius;
    [SerializeField]
    LayerMask groundLayer;
    private bool checkingGround;
    private bool checkingWall;

    private Rigidbody2D enemyRB;
    private Animator animator;

    void Start()
    {
        enemyRB = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        checkingGround = Physics2D.OverlapCircle(groundCheckPoint.position, circleRadius, groundLayer);
        checkingWall = Physics2D.OverlapCircle(wallCheckPoint.position, circleRadius, groundLayer);
        Petrolling();
        animator.SetBool("IsRunning", true);
    }

    void Petrolling()
    {
        if(!checkingGround || checkingWall)
        {
            if(facingRight)
            {
                Flip();
            }
            else if (!facingRight)
            {
                Flip();
            }
        }
        
        enemyRB.velocity = new Vector2(moveSpeed * moveDirection, enemyRB.velocity.y);
    }

    void Flip()
    {
        moveDirection *= -1;
        facingRight = !facingRight;
        transform.Rotate(0, 180,0);
    }
}
