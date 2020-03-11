using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleBoxPuzzleManager : PuzzleManager
{
    //Currently makes lock disappear when it's opened. May be replaced with animation later
    [SerializeField]
    private GameObject Lock;

    public override void InteractWithPuzzle(int ID)
    {
        base.InteractWithPuzzle(ID);
        if(ID == 6)
        {
            Lock.SetActive(false);
            InteractivePuzzle.EnvironmentIDs[1] = 0;
        }
    }
}
