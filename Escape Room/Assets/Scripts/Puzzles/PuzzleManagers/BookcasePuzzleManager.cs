using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookcasePuzzleManager : PuzzleManager
{
    [SerializeField]
    private GameObject Book;

    protected override void Awake()
    {
        base.Awake();
        Book.SetActive(false);
    }

    public override void InteractWithPuzzle(int ID)
    {
        base.InteractWithPuzzle(ID);
        if(ID == 7)
        {
            Book.SetActive(true);
            InteractivePuzzle.EnvironmentIDs[0] = 0;
        }
    }
}
