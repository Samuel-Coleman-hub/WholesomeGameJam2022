using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{

    public static TimeManager instance;
    public enum players { Computer, Player};
    bool playerTurn;

    int currentTurn;
    [SerializeField] BasicAi Ai;

    public void EndTurn()
    {
        bool gameOver = BoardManager.instance.checkGameOver();
        if (gameOver)
        {
            return;
        }

        playerTurn = !playerTurn;
        if (!playerTurn)
        {
            Ai.playTurn();
        }
    }

    public void decideFirstPlayer()
    {
        int rand = Random.Range(0, 1);
        if(rand == 0)
        {
            playerTurn = true;
        } else
        {
            playerTurn = false;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        currentTurn = 0;
        instance = this;

        if(!playerTurn)
        {
            Ai.playTurn();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
