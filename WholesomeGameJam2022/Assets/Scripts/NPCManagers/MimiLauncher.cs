using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MimiLauncher : NPCManager
{
    [SerializeField] GameObject dialog2pick;
    [SerializeField] GameObject campFire;

    

    [SerializeField] AllyManager allyManager;
    bool noReturn = false;

    public override GameObject pickDialog()
    {
        if (!allyManager.allies.Contains("Mimi"))
        {
            return dialog2pick;
        } else
        {
            returnNothing = true;
            return campFire;
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
