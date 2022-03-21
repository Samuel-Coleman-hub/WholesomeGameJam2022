using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class QuestionManagerQuizz : MonoBehaviour
{
    [SerializeField] GameObject dialogManager;
    public GameManager dialogResearcher;

    int currentQuestion = 1;
    int nbQuestions = 4;

    List<int> performances;

    [SerializeField] GameObject questions;

    public bool loop = false;
    [SerializeField] GameObject [] toHideWhenReset;
    [SerializeField] GameObject [] toShowWhenReset;




    public void onClick()
    {
        GameObject button = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject;
        GameObject answer = (button.transform.parent).parent.Find("RightAnswer").GetChild(0).gameObject;
        if(answer.name == button.name)
        {
            button.GetComponent<Image>().color = Color.green;
            Debug.Log("correct");
            performances.Add(1);
        } else
        {
            button.GetComponent<Image>().color = Color.red;
            Debug.Log("incorrect");
            performances.Add(0);
        }
        currentQuestion++;
        //(button.transform.parent).parent.gameObject.SetActive(false);
        transition((button.transform.parent).parent.gameObject);
    }
    
    void transition(GameObject go)
    {

        go.SetActive(false);
        if(currentQuestion <= 4)
        {
            questions.transform.GetChild(currentQuestion - 1).gameObject.SetActive(true);
        } else
        {
            //a boolean would have been better than a list
            if (performances.Contains(0))
            {
                Debug.Log("fail");
                dialogManager.GetComponent<DialogManager>().advanceToFail();
                if (loop)
                {
                    reset();

                }

            }
            else
            {
                dialogManager.GetComponent<DialogManager>().advanceToWin();
                if (loop)
                {
                    reset();
                }
                Debug.Log("Success");
            }
        }
    }

    void reset()
    {
        for (int i = 0; i < toShowWhenReset.Length; i++)
        {
            toShowWhenReset[i].SetActive(true);
        }

        for (int i = 0; i < toHideWhenReset.Length; i++)
        {
            toHideWhenReset[i].SetActive(false);
        }
        currentQuestion = 1;

        performances = new List<int>() ;
    }
    // Start is called before the first frame update
    void Start()
    {
        performances = new List<int>();
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
