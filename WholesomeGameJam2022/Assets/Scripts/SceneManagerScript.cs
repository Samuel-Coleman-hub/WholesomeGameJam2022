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
            SceneManager.LoadScene("BaseCamp");
        }
    }

    public void GotToIslandOne()
    {
        if (SceneManager.GetActiveScene().name != "Island 1")
        {
            SceneManager.LoadScene("Island 1");
        }
    }

    public void GoToIslandTwo()
    {
        if (SceneManager.GetActiveScene().name != "Island 2")
        {
            SceneManager.LoadScene("Island 2");
        }
    }
}
