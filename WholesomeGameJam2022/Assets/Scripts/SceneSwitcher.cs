using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneSwitcher : MonoBehaviour
{

    [SerializeField] GameObject baseCamp;
    [SerializeField] GameObject level1;
    [SerializeField] GameObject mapBaseCamp;
    [SerializeField] GameObject mapLevel1;


    bool OnbaseCamp = true;


    public void GoToBaseCamp()
    {
        if (OnbaseCamp)
        {
            mapBaseCamp.SetActive(false);
        }
        baseCamp.SetActive(true);
        level1.SetActive(false);
        mapLevel1.SetActive(false);
        OnbaseCamp = true;
    }

    public void GotToIslandOne()
    {
        if (!OnbaseCamp)
        {
            mapLevel1.SetActive(false);
        }
        baseCamp.SetActive(false);
        level1.SetActive(true);
        mapBaseCamp.SetActive(false);
        OnbaseCamp = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (OnbaseCamp)
            {
                if (mapBaseCamp.gameObject.activeSelf)
                {
                    mapBaseCamp.gameObject.SetActive(false);
                } else
                {
                    mapBaseCamp.gameObject.SetActive(true);
                }
            } else
            {
                if (mapLevel1.gameObject.activeSelf)
                {
                    mapLevel1.gameObject.SetActive(false);
                }
                else
                {
                    mapLevel1.gameObject.SetActive(true);
                }
            }
        }
        
    }
}
