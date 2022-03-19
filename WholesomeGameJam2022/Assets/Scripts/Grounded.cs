using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grounded : MonoBehaviour
{
    private GameObject player;
    private void Start()
    {
        player = gameObject.transform.parent.gameObject;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Ground")
        {
            player.GetComponent<Move2D>().isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        player.GetComponent<Move2D>().isGrounded = false;
    }
}
