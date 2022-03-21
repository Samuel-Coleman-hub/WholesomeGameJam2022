using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class QuestionManagerQuizz : MonoBehaviour
{
    [SerializeField] GameObject dialogManager;
    public GameManager dialogResearcher;

    int currentQuestion = 1;
    int nbQuestions = 5;

    List<int> performances;

    [SerializeField] GameObject questions;



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
        StartCoroutine(transition((button.transform.parent).parent.gameObject));
    }
    
    IEnumerator transition(GameObject go)
    {

        yield return new WaitForSeconds(0.2f);
        go.SetActive(false);
        yield return new WaitForSeconds(0.2f);
        if(currentQuestion <= 5)
        {
            questions.transform.GetChild(currentQuestion - 1).gameObject.SetActive(true);
        } else
        {
            //a boolean would have been better than a list
            if (performances.Contains(0))
            {
                Debug.Log("fail");
                dialogManager.GetComponent<DialogManager>().advanceToFail();

            }
            else
            {
                dialogManager.GetComponent<DialogManager>().advanceToWin();
                Debug.Log("Success");
            }
        }
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
