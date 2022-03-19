using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIStrategy : MonoBehaviour
{
    public int state = 0;
    [SerializeField] Sprite sprite;

    public virtual GameObject selectBox()
    {
        return null;
    }
    public virtual void playTurn()
    {
        BoardManager.instance.updateState(selectBox(), 0, sprite);
        TimeManager.instance.EndTurn();
    }
}
