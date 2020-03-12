using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrandfatherClockPuzzleManager : PuzzleManager
{
    private bool[] Weights = new bool[3];
    [SerializeField]
    private MeshRenderer Weight1, Weight2, Weight3;

    private InteractivePuzzle interactivePuzzle;

    protected override void Awake()
    {
        base.Awake();
        Weight1.enabled = Weight2.enabled = Weight3.enabled = false;
        interactivePuzzle = GetComponent<InteractivePuzzle>();
    }

    public override void InteractWithPuzzle(int ID)
    {
        base.InteractWithPuzzle(ID);
        if(ID == 9)
        {
            Weight1.enabled = true;
            Weights[0] = true;
        }
        if(ID == 10)
        {
            Weight2.enabled = true;
            Weights[1] = true;
        }
        if(ID == 11)
        {
            Weight3.enabled = true;
            Weights[2] = true;
        }
        if(Weights[0] && Weights[1] && Weights[2])
        {
            interactivePuzzle.EnvironmentIDs[0] = 0;
        }
    }
}
