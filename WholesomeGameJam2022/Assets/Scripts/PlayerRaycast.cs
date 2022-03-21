using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRaycast : MonoBehaviour
{
    [SerializeField] GameObject raycastPointRight;
    [SerializeField] GameObject raycastPointLeft;
    GameObject box;
    void FixedUpdate()
    {
        string directionMoving = GetComponent<Move2D>().directionMoving;
        Vector2 direction;
        GameObject raycastPoint;
        if (directionMoving == "Right")
        {
            direction = Vector2.right;
            raycastPoint = raycastPointRight;
        }
        else
        {
            direction = -Vector2.right;
            raycastPoint = raycastPointLeft;
        }

        RaycastHit2D hit = Physics2D.Raycast(raycastPoint.transform.position, direction, 3f);
        Debug.DrawRay(raycastPoint.transform.position, direction, Color.green);

        if (hit.collider != null && hit.collider.tag == "NPC")
        {
            box = hit.collider.gameObject.transform.Find("Box").gameObject;
            hit.collider.gameObject.transform.Find("Box").gameObject.SetActive(true);

            if(Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("Talk to NPC");
                Debug.Log(hit.collider.name);
                hit.collider.gameObject.GetComponent<NPCManager>().playDialogue();
            }
        } else
        {
            if(box != null)
            {
                box.SetActive(false);
                box = null;
            }
        }
    }
}
