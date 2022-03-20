using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishMoveManager : MonoBehaviour
{
    [SerializeField] GameObject entity;

    public bool isMoving = false;

    public IEnumerator Move(Vector3 target, float speed)
    {
        isMoving = true;
        Vector2 targetPosition = new Vector2(target.x, entity.transform.position.y);
        while (Vector2.Distance(entity.transform.position, targetPosition) != 0f)
        {
            entity.transform.position = Vector2.MoveTowards(entity.transform.position, targetPosition, speed * Time.deltaTime);
            yield return null;
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
