using System.Collections;
using UnityEngine;

public class FishBehaviour : MonoBehaviour
{
    public Vector3 pointB;
    public float maxSpeed = 12;
    public float normalSpeed = 11;
    public float minSpeed = 10;

    private Coroutine moveForward;
    private Coroutine moveBackward;

    [SerializeField] LayerMask rodLayer;

    public void getCaught()
    {
        StopCoroutine(moveForward);
        StopCoroutine(moveBackward);
        StartCoroutine(MoveObject(transform, transform.position, pointB, 3.0f, maxSpeed));
    }

    public void escape()
    {

    }

    IEnumerator Start()
    {
     
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.left,100, rodLayer.value);
        if (hit.collider != null)
        {

            pointB = hit.collider.gameObject.transform.position;
            Debug.Log(pointB);
            Debug.Log(hit.collider.gameObject.name);
            pointB.y = transform.position.y;
            

        }
        var pointA = transform.position;
        while (true)
        {
            
            moveForward = StartCoroutine(MoveObject(transform, pointA, pointB, 3.0f, Random.Range(normalSpeed, maxSpeed)));
            yield return moveForward;
            pointA = pointB + new Vector3(Random.Range(1.0f, 1.4f), 0, 0);
            moveBackward = StartCoroutine(MoveObject(transform, pointB, pointA, 3.0f, Random.Range(minSpeed, normalSpeed)));
            yield return moveBackward;
        }
    }

    IEnumerator MoveObject(Transform thisTransform, Vector3 startPos, Vector3 endPos, float time, float speed)
    {
        var i = 0.0f;
        var rate = 1.0f / time;
        while (i < 1.0f)
        {
            i += speed*Time.deltaTime * rate;
            thisTransform.position = Vector3.Lerp(startPos, endPos, i);
            yield return null;
        }

    }


  
}
