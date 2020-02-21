using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circuits : MonoBehaviour
{
    [SerializeField]
    int y, z;

    [SerializeField]
    Transform thisRotation;
    
    public int RotationNumber;

    public void ChangeState(int whichOne)
    {
        switch (whichOne)
        {
            case 1:
                RotationNumber = 1;
                thisRotation.Rotate(0, y, z);
                break;

            case 2:
                RotationNumber = 2;
                thisRotation.Rotate(90, y, z);
                break;

            case 3:
                RotationNumber = 3;
                thisRotation.Rotate(180, y, z);
                break;

            case 4:
                RotationNumber = 4;
                thisRotation.Rotate(270, y, z);
                break;
        }

    }
}
