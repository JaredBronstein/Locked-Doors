using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    protected InteractivePuzzle InteractivePuzzle;
    /// <summary>
    /// Void made to be called by the Interactive Puzzle class when interacted with by an ID other than 0
    /// It's sole purpose is to be a parent class each individual puzzle will have a child to for uniformity
    /// This void is made to be overwritten
    /// </summary>
    /// <param name="ID"></param>
    public virtual void InteractWithPuzzle(int ID)
    {

    }
    protected virtual void Awake()
    {
        InteractivePuzzle = GetComponent<InteractivePuzzle>();
    }
}
