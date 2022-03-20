using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGameBox : MonoBehaviour
{
    GameObject gameBox;
    [SerializeField] GameObject game;
    public void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            gameBox.SetActive(false);
            game.SetActive(false);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        gameBox = gameObject.transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
