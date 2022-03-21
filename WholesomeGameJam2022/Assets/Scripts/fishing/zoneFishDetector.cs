using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zoneFishDetector : MonoBehaviour
{
    [SerializeField] GameObject rightCollider;
    [SerializeField] GameObject game;
    [SerializeField] GameObject boxGame;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            RaycastHit2D hit = Physics2D.Raycast(gameObject.transform.position, Vector2.right,1.5f);
            if(hit.collider != null)
            {
                Debug.Log(hit.collider.name);
                if(hit.collider.gameObject == rightCollider)
                {
                    
                    //game.transform.parent.gameObject.SetActive(true);
                    game.SetActive(true);
                    //boxGame.SetActive(true);
                }
            }
        }
        
    }
}
