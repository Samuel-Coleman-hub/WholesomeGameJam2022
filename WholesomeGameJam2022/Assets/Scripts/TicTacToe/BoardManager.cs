using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour
{
    public static BoardManager instance;
    public int state;
    [SerializeField] GameObject timeManager;

    [SerializeField] GameObject board;
    [SerializeField] List<GameObject> emptyBoxes;
    private List<GameObject> boxes;

    int nbBox = 9;

    public void updateState(GameObject box, int state, Sprite sprite)
    {
        box.GetComponent<SpriteRenderer>().sprite = sprite;
        box.GetComponent<BoxTicTacToe>().state = state;
        emptyBoxes.Remove(box);
    }

    bool validate(List<GameObject> boxes)
    {
        bool valid = true;
        int firstState = boxes[0].GetComponent<BoxTicTacToe>().state;
        if(firstState == -1)
        {
            return false;
        }
        foreach (GameObject box in boxes)
        {
            valid = valid & (box.GetComponent<BoxTicTacToe>().state == firstState);
        }
        return valid;
    }

    bool validateColumns()
    {
        return validate(new List<GameObject> { boxes[0], boxes[3], boxes[6] }) ||
            validate(new List<GameObject> { boxes[1], boxes[4], boxes[7] }) ||
            validate(new List<GameObject> { boxes[2], boxes[5], boxes[8] });
    }

    bool validateRows()
    {
        return validate(new List<GameObject> { boxes[0], boxes[1], boxes[2] }) ||
            validate(new List<GameObject> { boxes[3], boxes[4], boxes[5] }) ||
            validate(new List<GameObject> { boxes[6], boxes[7], boxes[8] });
    }

    bool validateDiagonal()
    {
        return validate(new List<GameObject> { boxes[0], boxes[4], boxes[8] }) ||
            validate(new List<GameObject> { boxes[2], boxes[4], boxes[6] }) ;
    }

    public bool checkGameOver()
    {
        if (validateColumns() || validateRows() || validateDiagonal())
        {
            Debug.Log("done");
            StartCoroutine(exitGame());
            return true;
        }
        return false;

    }

    public IEnumerator exitGame()
    {
        yield return new WaitForSeconds(1);
        GameObject.Find("TicTacToe").SetActive(false);
    }

    public List<GameObject> getEmptyBoxes()
    {
        return emptyBoxes;
    }


    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        emptyBoxes = new List<GameObject>();
        boxes = new List<GameObject>();

        for (int i = 0; i < nbBox; i++)
        {
            emptyBoxes.Add(board.transform.GetChild(i).gameObject);
            boxes.Add(board.transform.GetChild(i).gameObject);
        }
        timeManager.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
