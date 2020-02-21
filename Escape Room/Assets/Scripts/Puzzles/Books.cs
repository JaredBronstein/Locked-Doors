using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Books : MonoBehaviour
{
    public int BookNumber;

    public void ChangeState(int whichOne)
    {
        switch (whichOne)
        {
            case 1:
                BookNumber = 1;
                break;

            case 2:
                BookNumber = 2;
                break;

            case 3:
                BookNumber = 3;
                break;

            case 4:
                BookNumber = 4;
                break;
        }

    }
}
