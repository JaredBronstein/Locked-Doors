using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonogramManager : PuzzleManager
{
    public override void InteractWithPuzzle(int ID)
    {
        base.InteractWithPuzzle(ID);
        if(ID == 2)
        {
            InteractivePuzzle.EnvironmentIDs[1] = 0;
        }
    }
}
