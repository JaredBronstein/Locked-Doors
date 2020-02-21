using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleBlock : MonoBehaviour
{
    public bool isKey, isHole, isBlocked, isOpen;

    public void ChangeState(int whichOne)
    {
        switch (whichOne)
        {
            case 1:
                isKey = true;
                isHole = false;
                isBlocked = false;
                isOpen = false;
                break;

            case 2:
                isKey = false;
                isHole = true;
                isBlocked = false;
                isOpen = false;
                break;

            case 3:
                isKey = false;
                isHole = false;
                isBlocked = true;
                isOpen = false;
                break;

            case 4:
                isKey = false;
                isHole = false;
                isBlocked = false;
                isOpen = true;
                break;
        }
    
    }
}
