using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MimiLauncher : NPCManager
{
    [SerializeField] GameObject dialog2pick;
    [SerializeField] AllyManager allyManager;

    public override GameObject pickDialog()
    {
        return dialog2pick;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        returnNothing = allyManager.allies.Contains("Mimi");
       
    }
}
