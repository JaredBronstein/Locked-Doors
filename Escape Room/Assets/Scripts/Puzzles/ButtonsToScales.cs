using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Created By Jonathan Way
public class ButtonsToScales : MonoBehaviour
{
    [SerializeField]
    ScalesPuzzle Scales;

    int thisButton;

    public void ToScales(int thisOne)
    {
        Scales.MoveScales(thisOne);
    }

}
