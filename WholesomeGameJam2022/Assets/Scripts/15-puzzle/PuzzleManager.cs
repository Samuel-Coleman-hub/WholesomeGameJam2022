using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleManager : MonoBehaviour
{


    private List<GameObject> rightSequence;
    private int nbBox = 15;

    void initGame()
    {
        rightSequence = new List<GameObject>();
        for(int i = 0; i < 15; i++)
        {
            rightSequence.Add(gameObject.transform.Find("boxes").GetChild(i).gameObject);
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
