using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlbertLauncher : NPCManager
{
    [SerializeField] List<GameObject> albertDialogs;
    bool beforeRecruitment = false;
    bool refuse = false;
    bool win = false;
    bool campFire;
    [SerializeField] AllyManager allyManager;
    [SerializeField] GameObject player;
    public bool firstDialog = true;


    public override GameObject pickDialog()
    {
        Debug.Log("piiiiiiiiiiiick");
        if (firstDialog)
        {
            firstDialog = false;
            return albertDialogs[0];
        } else
        {
            if (player.transform.Find("QuizzState").Find("QuizzRefused").gameObject.activeSelf)
            {
                Debug.Log("refused");
            } else
            {
                if (player.transform.Find("QuizzState").Find("QuizzWon").gameObject.activeSelf)
                {
                    if (!win)
                    {
                        win = true;
                        return albertDialogs[2];
                    } else
                    {
                        Debug.Log("return nothing");
                        returnNothing = true;
                        return albertDialogs[3];
                    }
                   

                }
                else
                {
                    return albertDialogs[1];
                }
            }
            return null;
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
