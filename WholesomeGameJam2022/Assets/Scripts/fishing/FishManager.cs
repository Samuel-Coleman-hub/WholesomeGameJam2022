using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishManager : MonoBehaviour
{
    [SerializeField] GameObject fish;
    [SerializeField] GameObject rod;
    public float maxDistance;


    public void validateFishing()
    {
        Debug.Log("fish.transform.position.x - rod.transform.position.x: " + (fish.transform.position.x - rod.transform.position.x));
        Debug.Log("fish.transform.position.x: " + (fish.transform.position.x)); 
        Debug.Log("rod.transform.position.x: " + (rod.transform.position.x));


        if (Mathf.Abs(fish.transform.position.x - rod.transform.position.x) < maxDistance)
        {
            Debug.Log("done");
            fish.GetComponent<FishBehaviour>().getCaught();
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
