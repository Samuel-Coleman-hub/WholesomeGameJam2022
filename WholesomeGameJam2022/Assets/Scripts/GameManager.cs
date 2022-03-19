using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject mapUI;
    [SerializeField] GameObject player;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            mapUI.SetActive(!mapUI.activeSelf);
            player.GetComponent<Move2D>().enabled = !player.GetComponent<Move2D>().enabled;
        }
    }
}
