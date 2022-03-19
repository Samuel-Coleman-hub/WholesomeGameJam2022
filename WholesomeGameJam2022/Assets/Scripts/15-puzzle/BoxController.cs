using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BoxController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Transform boxTarget;
    public int positionX;
    public int positionY;
    public bool isControllable;
    [SerializeField] Vector2 correctPosition;

    public void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            MoveManager.instance.Move(this);
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        positionX = (int)Mathf.Floor(transform.position.x);
        positionY = (int)Mathf.Floor(transform.position.y);
        boxTarget = transform;
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
