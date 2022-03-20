using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveManager : MonoBehaviour
{
    public static MoveManager instance;
    [SerializeField] GameObject emptyBox;
    public MoveManager()
    {
        instance = this;
    }


    public IEnumerator Move(BoxController entity,float targetX, float targetY)
    {
        Vector2 targetPosition =  new Vector2(targetX, targetY);
        while (Vector2.Distance(entity.transform.position, targetPosition) != 0f)
        {
            entity.transform.position = Vector2.MoveTowards(entity.transform.position, targetPosition, entity.moveSpeed * Time.deltaTime);
            yield return null;
        }
        PuzzleManager.instance.endGameIfSolved(emptyBox);

    }

    public bool canMove(BoxController box)
    {
        if (Mathf.Abs(box.transform.position.x - emptyBox.transform.position.x) <= 0.1f)
        {
            if (Mathf.Abs(box.transform.position.y - emptyBox.transform.position.y) <= 0.8)
            {
                return true;
            }
        }

        if (Mathf.Abs(box.transform.position.y - emptyBox.transform.position.y) <= 0.1f)
        {
            if (Mathf.Abs(box.transform.position.x - emptyBox.transform.position.x) <= 1.5)
            {
                return true;
            }
        }
        /*if (Vector3.Distance(box.transform.position, emptyBox.transform.position) != 1)
        {
            return false;
        }*/
        return false;
    }

    public void Move(BoxController box)
    {

        if (canMove(box))
        {
            float targetX = emptyBox.transform.position.x;
            float targetY = emptyBox.transform.position.y;
            box.positionX = (int) targetX;
            box.positionY = (int) targetY;

            emptyBox.transform.position = box.transform.position;
            StartCoroutine(Move(box, targetX, targetY));
        }
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}