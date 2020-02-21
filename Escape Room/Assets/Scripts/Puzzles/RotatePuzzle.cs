using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePuzzle : MonoBehaviour
{
    [SerializeField]
    GameObject[] rotatingWiresLocations;

    [SerializeField]
    int[] puzzleCode;

    Transform thisTransform;
    Circuits thisCircuit;

    public bool correctFormation;
    
    void Awake()
    {
        correctFormation = false;
    }

    // Update is called once per frame
    void Update()
    {
        CheckRotations(); 
    }

    public void ChangeRotation(int whichOne)
    {
        thisCircuit = rotatingWiresLocations[whichOne - 1].GetComponent<Circuits>();
        if (thisCircuit.RotationNumber == 4)
            thisCircuit.RotationNumber = 0;

        thisCircuit.ChangeState(thisCircuit.RotationNumber + 1);
    }

    private void CheckRotations()
    {
        for(int i = 0; i < rotatingWiresLocations.Length; i++)
        {
            thisCircuit = rotatingWiresLocations[i].GetComponent<Circuits>();
            if (thisCircuit.RotationNumber == puzzleCode[i])
                correctFormation = true;
            else
            {
                correctFormation = false;
                i = rotatingWiresLocations.Length; 
            }
        }
    }
}
