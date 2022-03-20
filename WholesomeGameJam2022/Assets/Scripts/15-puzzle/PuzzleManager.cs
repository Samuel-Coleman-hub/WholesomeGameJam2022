using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    public static PuzzleManager instance;
    [SerializeField] DialogManager dialogManager;

    public List<Vector3> rightSequencePositions;
    private int nbBox = 16;
    private List<int> initSequence;
    [SerializeField] GameObject boxes;

    private List<int> initTestSequence;

    public PuzzleManager()
    {
        instance = this;
    }

    void initGame()
    {
        rightSequencePositions = new List<Vector3>();
        initSequence = new List<int>();
        rightSequencePositions = new List<Vector3>();

        for(int i = 0; i < nbBox; i++)
        {
            rightSequencePositions.Add(boxes.transform.GetChild(i).position);
            int rand = Random.Range(0, nbBox);
            while (initSequence.Contains(rand))
            {
                rand = Random.Range(0, nbBox);
            }
            initSequence.Add(rand);
        }
        shuffle();
    }

    public void shuffle()
    {
        initTestSequence = new List<int>()
        {
            0,1,2,3,4,5,6,7,8,9,10,11,12,13,15,14
        };


        for(int i = 0; i < nbBox; i++)
        {
            boxes.transform.GetChild(i).position = rightSequencePositions[initTestSequence[i]];
        }
    }

    public void endGameIfSolved(GameObject emptyBox)
    {
        if (isSolved(emptyBox))
        {
            //temporary
            Debug.Log("done");
            
            dialogManager.isPlaying = false;
            dialogManager.showNewDialog();
        }
    }

    public bool isSolved(GameObject emptyBox)
    {
        if(emptyBox.transform.position != rightSequencePositions[nbBox - 1])
        {
            return false;
        }

        
        for (int i = 0; i < nbBox; i++)
        {
            if (boxes.transform.GetChild(i).position != rightSequencePositions[i])
            {
                return false;
            }
        }

        return true;
    }

    // Start is called before the first frame update
    void Start()
    {
        initGame();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
