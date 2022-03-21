using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCManager : MonoBehaviour
{
    public bool returnNothing = false;

    public virtual void playDialogue()
    {
        if (!returnNothing)
        {
            GameObject dialog = pickDialog();
            dialog.SetActive(true);
            dialog.transform.Find("DialogManager").gameObject.SetActive(true);
        }
    }

    public virtual GameObject pickDialog()
    {
        return null;
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
