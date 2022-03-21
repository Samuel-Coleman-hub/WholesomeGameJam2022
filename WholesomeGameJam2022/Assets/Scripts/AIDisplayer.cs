using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIDisplayer : MonoBehaviour
{

    [SerializeField] AllyManager allies1;
    [SerializeField] AllyManager allies2;

    [SerializeField] GameObject displayer1;
    [SerializeField] GameObject displayer2;


    public void display(string character)
    {
        Debug.Log(character);
        Debug.Log(allies1.allies.Contains(character));
        Debug.Log(allies2.allies.Contains(character));
        if (allies1.allies.Contains(character) || allies2.allies.Contains(character))
        {
            displayer1.transform.Find(character).gameObject.SetActive(true);
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
