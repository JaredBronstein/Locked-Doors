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
        if(ID == 8)
        {
            Lock.SetActive(false);
            InteractivePuzzle.EnvironmentIDs[1] = 6;
        }
        if(ID == 6)
        {
            InteractivePuzzle.EnvironmentIDs[0] = 0;
        }
    }
}
