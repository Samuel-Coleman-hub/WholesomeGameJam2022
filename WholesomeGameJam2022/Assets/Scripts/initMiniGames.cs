using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class initMiniGames : MonoBehaviour
{

    float offset = 6;

    [SerializeField] GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        this.transform.position =  new Vector3 (player.transform.position.x + offset,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
