using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsToScales : MonoBehaviour
{
    [SerializeField]
    ScalesPuzzle Scales;

    int thisButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToScales(int thisOne)
    {
        Scales.MoveScales(thisOne);
    }

}
