using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
    // Start is called before the first frame update
    
    public void GoToBaseCamp()
    {
        SceneManager.LoadScene("BaseCamp");
    }

    public void GotToIslandOne()
    {
        SceneManager.LoadScene("Island 1");
    }

    public void GoToIslandTwo()
    {
        SceneManager.LoadScene("Island 2");
    }
}
