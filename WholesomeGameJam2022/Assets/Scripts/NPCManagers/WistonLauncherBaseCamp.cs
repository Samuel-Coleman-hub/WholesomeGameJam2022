using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WistonLauncherBaseCamp : NPCManager
{
    [SerializeField] GameObject dialog2pick;


    public override GameObject pickDialog()
    {
        returnNothing = true;
        return dialog2pick;
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
