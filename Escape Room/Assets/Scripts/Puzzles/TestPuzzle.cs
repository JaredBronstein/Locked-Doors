using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPuzzle : PuzzleManager
{
    [SerializeField]
    private GameObject Cube;
    [SerializeField]
    private Material Eric;

    protected int functionID = 1;
    

    public override void InteractWithPuzzle(int ID)
    {
        base.InteractWithPuzzle(ID);
        if(ID == functionID)
        {
            Cube.GetComponent<MeshRenderer>().material = Eric;
        }
    }
}
