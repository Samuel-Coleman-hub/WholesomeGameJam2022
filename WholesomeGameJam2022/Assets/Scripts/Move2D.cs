using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2D : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;

    public bool isGrounded = false;
    public string directionMoving = "Right";

    private Animator animator;
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * moveSpeed;

        if(movement.x > 0f)
        {
            directionMoving = "Right";
            animator.SetBool("isWalking", true);
            spriteRenderer.flipX = false;
        }
        else if(movement.x < 0f)
        {
            directionMoving = "Left";
            animator.SetBool("isWalking", true);
            spriteRenderer.flipX = true;
        }
        else
        {
            animator.SetBool("isWalking", false);
        }
    }

    private void Jump()
    {
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 5f), ForceMode2D.Impulse);
        }
        
    }
}
