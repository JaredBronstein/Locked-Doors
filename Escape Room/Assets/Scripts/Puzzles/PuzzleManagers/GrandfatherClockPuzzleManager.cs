using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrandfatherClockPuzzleManager : PuzzleManager
{
    private bool IsReady = false;
    [SerializeField]
    private GameObject Weight1, Weight2, Weight3;

    protected override void Awake()
    {
        base.Awake();
        Weight1.SetActive(false);
        Weight2.SetActive(false);
        Weight3.SetActive(false);
        IsReady = Weight1.activeInHierarchy && Weight2.activeInHierarchy && Weight3.activeInHierarchy;
    }

    public override void InteractWithPuzzle(int ID)
    {
        base.InteractWithPuzzle(ID);
        if(ID == 9)
        {
            Weight1.SetActive(true);
        }
        if(ID == 10)
        {
            Weight2.SetActive(true);
        }
        if(ID == 11)
        {
            Weight3.SetActive(true);
        }
        if(IsReady)
        {
            InteractivePuzzle.EnvironmentIDs[0] = 0;
        }
    }
}
