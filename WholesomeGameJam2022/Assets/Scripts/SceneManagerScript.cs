using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
    // Start is called before the first frame update
    
    public void GoToBaseCamp()
    {
        if(SceneManager.GetActiveScene().name != "BaseCamp")
        {
            if (SceneManager.GetActiveScene().name != "BaseCamp")
            {
                SceneManager.LoadScene("BaseCampBackUp");
            }
        }
    }

    public void GotToIslandOne()
    {
        /*
        GameObject.Find("BaseCamp").SetActive(false);
        GameObject.Find("Desert").SetActive(true);*/
    }

    public void GoToIslandTwo()
    {
        GameObject.Find("BaseCamp").SetActive(false);
        GameObject.Find("Desert").SetActive(true);
    }

    public void GoToStartMenu()
    {
        Debug.Log("Go back");
        SceneManager.LoadScene("Start Scene");
    }

    public void GoToCredits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
