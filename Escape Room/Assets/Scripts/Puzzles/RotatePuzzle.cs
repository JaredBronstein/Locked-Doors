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

    //audio
    //instantiating FMOD events
    FMOD.Studio.EventInstance PlaySound_CircuitRotate;
    FMOD.Studio.EventInstance PlaySound_CircuitSuccessThunk;
    FMOD.Studio.EventInstance PlaySound_CircuitSuccessHum;

    void Awake()
    {
        correctFormation = false;
    }

    //audio
    private void Start()
    {
        //linking audio events to FMOD middleware
        PlaySound_CircuitRotate = FMODUnity.RuntimeManager.CreateInstance("event:/Circuit Rotate");
        PlaySound_CircuitSuccessThunk = FMODUnity.RuntimeManager.CreateInstance("event:/Circuit Success Thunk");
        PlaySound_CircuitSuccessHum = FMODUnity.RuntimeManager.CreateInstance("event:/Circuit Success Hum");
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

        //audio
        PlaySound_CircuitRotate.start();

        //audio
        if (correctFormation)
        {
            PlaySound_CircuitSuccessThunk.start();
            PlaySound_CircuitSuccessHum.start();
        }
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
