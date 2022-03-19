using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxTicTacToe : MonoBehaviour
{
    // Start is called before the first frame update
    public int state;
    [SerializeField] Sprite sprite;


    public void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //player plays, so state is 1
            BoardManager.instance.updateState(this.gameObject, 1, sprite);
            TimeManager.instance.EndTurn();
        }
    }


    void Start()
    {
        state = -1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
