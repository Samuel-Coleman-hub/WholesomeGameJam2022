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

    public override GameObject pickDialog()
    {
        if (!allyManager.allies.Contains("Researcher"))
        {
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
                    Debug.Log("won");
                }
                else
                {
                    Debug.Log("lost");
                }
            }
        }
        return albertDialogs[0]; 
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
