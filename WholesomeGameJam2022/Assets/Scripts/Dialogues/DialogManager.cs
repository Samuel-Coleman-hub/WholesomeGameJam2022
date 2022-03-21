using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogManager : MonoBehaviour
{
    [SerializeField] GameObject Npc;
    int currentDialog = 0;
    [SerializeField] GameObject game;

    [SerializeField] string nameNPC;

    public bool isPlaying = false;
    public bool win = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void onClick()
    {
        GameObject button = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject;
        GameObject dialog = Npc.transform.GetChild(currentDialog).gameObject;
        dialog.transform.Find("Texts").gameObject.SetActive(false);
        Debug.Log(dialog.name);
        Debug.Log(button.name);
        Debug.Log(Npc.transform.GetChild(currentDialog).name);
        Npc = Npc.transform.GetChild(currentDialog).gameObject.transform.Find("Choice").Find(button.name).gameObject;
        Npc.SetActive(true);
        
        currentDialog = 0;
        dialog.gameObject.transform.Find("Buttons").Find("Yes").gameObject.SetActive(false);
        dialog.gameObject.transform.Find("Buttons").Find("No").gameObject.SetActive(false);
    }

    public void showNewDialog()
    {
        currentDialog++;
        GameObject newDialog = Npc.transform.GetChild(currentDialog).gameObject;
        newDialog.SetActive(true);
        game.transform.parent.gameObject.SetActive(false);
        game.SetActive(false);
    }

    public void advanceToFail()
    {
        Debug.Log("my name : " + Npc.name);
        GameObject dialog;
        if (currentDialog == 0)
        {
            dialog = Npc.transform.GetChild(currentDialog).gameObject;

        }
        else
        {
            dialog = Npc.transform.GetChild(currentDialog - 1).gameObject;
        }
        Debug.Log("aaaaaaa"+ dialog.name);
        dialog.SetActive(true);
        dialog.transform.Find("Texts").gameObject.SetActive(false);
        Npc =dialog.transform.Find("Game").Find("Lose").gameObject;
        Debug.Log(Npc.name);
        Npc.gameObject.SetActive(true);
        isPlaying = false;
        currentDialog = 0;


    }
    public void advanceToWin()
    {

        GameObject dialog = Npc.transform.GetChild(currentDialog - 1).gameObject;

        dialog.SetActive(true);
 
        dialog.transform.Find("Texts").gameObject.SetActive(false);
        Npc = Npc.transform.GetChild(currentDialog-1).gameObject.transform.Find("Game").Find("Win").gameObject;
        Npc.gameObject.SetActive(true);
        isPlaying = false;
        currentDialog = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if(Npc != null)
        {
            //Debug.Log(Npc.name);
        }
        //Debug.Log(currentDialog);
        if(currentDialog < Npc.transform.childCount)
        {
            if (Npc.transform.GetChild(currentDialog).gameObject.transform.Find("Choice") != null)
            {

            }
            else
            {
                
                if (Input.GetMouseButtonDown(0) && !isPlaying)
                {
                    Debug.Log(currentDialog);


                    GameObject dialog = Npc.transform.GetChild(currentDialog).gameObject;
                    dialog.SetActive(false);
                    currentDialog++;

                    if (dialog.transform.Find("Ally"))
                    {
                        GameValues.allies.Add(nameNPC);
                        GameObject.Find("Player").GetComponent<AllyManager>().allies.Add(nameNPC);
                    }

                    if (dialog.transform.Find("QuizzDeclined"))
                    {
                        GameObject.Find("Player").transform.Find("QuizzState").Find("QuizzRefused").gameObject.SetActive(true);
                    }

                    if (dialog.transform.Find("QuizzWon"))
                    {
                        GameObject.Find("Player").transform.Find("QuizzState").Find("QuizzWon").gameObject.SetActive(true);
                        GameObject.Find("Player").transform.Find("QuizzState").Find("QuizzLost").gameObject.SetActive(false);
                    }

                    if (dialog.transform.Find("QuizzLost"))
                    {
                        GameObject.Find("Player").transform.Find("QuizzState").Find("QuizzWon").gameObject.SetActive(false);
                        GameObject.Find("Player").transform.Find("QuizzState").Find("QuizzLost").gameObject.SetActive(true);
                    }

                    if (dialog.transform.Find("QuizzAccepted"))
                    {
                        GameObject.Find("Player").transform.Find("QuizzState").Find("QuizzRefused").gameObject.SetActive(false);
                    }

                    if (dialog.transform.Find("Game"))
                    {
                        isPlaying = true;
                        if(game.transform.parent != null)
                        {
                            game.transform.parent.gameObject.SetActive(true);
                        }
                        game.SetActive(true);
                    }
                    else
                    {
                        if(currentDialog < Npc.transform.childCount)
                        {
                            
                            GameObject newDialog = Npc.transform.GetChild(currentDialog).gameObject;
                            if(newDialog.name != "Ally" && newDialog.name != "DialogManager")
                            {
                                Debug.Log(newDialog.name);
                                newDialog.SetActive(true);
                            } else
                            {
                                currentDialog++;
                            }
                           
                        } 
                    }
                    if (currentDialog > Npc.transform.childCount)
                    {
                        gameObject.transform.parent.gameObject.SetActive(false);
                        gameObject.SetActive(false);
                    }

                }
            }
        }  else
        {
            gameObject.transform.parent.gameObject.SetActive(false);
            gameObject.SetActive(false);

        }

    }
}
