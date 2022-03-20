using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicAi : AIStrategy
{
    [SerializeField] BoardManager boardManager;
    override public GameObject selectBox()
    {
        
        List<GameObject> emptyBox = BoardManager.instance.getEmptyBoxes();
        int n = emptyBox.Count;
        int choice = Random.Range(0, n);
        return emptyBox[choice];
    }

    public override void playTurn()
    {
        base.playTurn();

    }

}
