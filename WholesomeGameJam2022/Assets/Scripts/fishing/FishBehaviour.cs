using System.Collections;
using UnityEngine;

public class FishBehaviour : MonoBehaviour
{

    [SerializeField] fishMoveManager fishMoveManager;
    public float speed = 1;
    GameObject target;
    private IEnumerator coroutine;
    public enum behaviour
    {
        easyToCatch,
        normal,
        hardToCatch
    }

    // Start is called before the first frame update
    void Start()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right);
        if(hit.collider!= null)
        {

            target = hit.collider.gameObject;
            coroutine = fishMoveManager.Move(target.transform.position,speed);            
            StartCoroutine(coroutine);
        }


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        StopCoroutine(coroutine);
        fishMoveManager.Move(target.transform.position - new Vector3(1,0,0), speed);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
