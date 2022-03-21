using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WistonLauncher : NPCManager
{
    [SerializeField] GameObject [] WistonDialogs;
    [SerializeField] AllyManager allyManager;
    [SerializeField] GameObject player;


    bool firstDialog = false;
    bool secondDialog = false;
    public bool hasFish = false;

    public override GameObject pickDialog()
    {

        if (!allyManager.allies.Contains("Mimi"))
        {
            return WistonDialogs[0];
        } else
        {
            if (player.transform.Find("Fish").gameObject.activeSelf && !secondDialog)
            {
                secondDialog = true;
                return WistonDialogs[2];
            }
            else if (!firstDialog && !secondDialog)
            {
                firstDialog = true;
                return WistonDialogs[1];
            }
            else
            {
                returnNothing = true;
                return WistonDialogs[3];
            }
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
