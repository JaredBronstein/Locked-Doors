using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsToBlocks : MonoBehaviour
{
    [SerializeField]
    BlockPuzzleScript puzzleScript;

    [SerializeField]
    GameObject[] BlockButtons;

    public void ButtonBlocks9(int thisOne)
    {
        switch (thisOne)
        {
            case 1:
                puzzleScript.MovingBlocks9(1);

                ResetButtons();
                BlockButtons[0].SetActive(false);
                BlockButtons[1].SetActive(true);
                BlockButtons[3].SetActive(true);
                break;

            case 2:
                puzzleScript.MovingBlocks9(2);

                ResetButtons();
                BlockButtons[1].SetActive(false);
                BlockButtons[0].SetActive(true);
                BlockButtons[4].SetActive(true);
                BlockButtons[2].SetActive(true);
                break;

            case 3:
                puzzleScript.MovingBlocks9(3);

                ResetButtons();
                BlockButtons[2].SetActive(false);
                BlockButtons[1].SetActive(true);
                BlockButtons[5].SetActive(true);
                break;

            case 4:
                puzzleScript.MovingBlocks9(4);

                ResetButtons();
                BlockButtons[3].SetActive(false);
                BlockButtons[0].SetActive(true);
                BlockButtons[4].SetActive(true);
                BlockButtons[6].SetActive(true);
                break;

            case 5:
                puzzleScript.MovingBlocks9(5);

                ResetButtons();
                BlockButtons[4].SetActive(false);
                BlockButtons[1].SetActive(true);
                BlockButtons[3].SetActive(true);
                BlockButtons[5].SetActive(true);
                BlockButtons[7].SetActive(true);
                break;

            case 6:
                puzzleScript.MovingBlocks9(6);

                ResetButtons();
                BlockButtons[5].SetActive(false);
                BlockButtons[2].SetActive(true);
                BlockButtons[4].SetActive(true);
                BlockButtons[8].SetActive(true);
                break;

            case 7:
                puzzleScript.MovingBlocks9(7);

                ResetButtons();
                BlockButtons[6].SetActive(false);
                BlockButtons[3].SetActive(true);
                BlockButtons[7].SetActive(true);
                break;

            case 8:
                puzzleScript.MovingBlocks9(8);

                ResetButtons();
                BlockButtons[7].SetActive(false);
                BlockButtons[6].SetActive(true);
                BlockButtons[4].SetActive(true);
                BlockButtons[8].SetActive(true);
                break;

            case 9:
                puzzleScript.MovingBlocks9(9);

                ResetButtons();
                BlockButtons[8].SetActive(false);
                BlockButtons[5].SetActive(true);
                BlockButtons[7].SetActive(true);
                break;
        }
    }

    void ResetButtons()
    {
        for (int i = 0; i < BlockButtons.Length; i++)
            BlockButtons[i].SetActive(false);
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
