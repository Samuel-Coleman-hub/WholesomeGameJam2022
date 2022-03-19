using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchBackground : MonoBehaviour
{
    [SerializeField] float timeToWait = 1f;
    [SerializeField] Sprite secondaryBackground;
    private Sprite background;
    // Start is called before the first frame update
    void Start()
    {
        background = GetComponent<SpriteRenderer>().sprite;
        StartCoroutine(switchBackground());
    }

    IEnumerator switchBackground()
    {
        if(GetComponent<SpriteRenderer>().sprite == secondaryBackground)
        {
            GetComponent<SpriteRenderer>().sprite = background;
        }
        else
        {
            GetComponent<SpriteRenderer>().sprite = secondaryBackground;
        }

        yield return new WaitForSeconds(timeToWait);
        StartCoroutine(switchBackground());
    }
}
