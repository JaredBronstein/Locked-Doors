using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//Created by Jared Bronstein

public class Safe : MonoBehaviour
{
    [SerializeField]
    private GameObject Dial;
    [SerializeField]
    private int CodeOne = 1, CodeTwo = 12, CodeThree = 20;
    [SerializeField]
    private Text CodeDisplay;
    [SerializeField]
    private InteractivePuzzle SafePuzzle;
    [SerializeField]
    private Animator DoorAnimator;

    private float Direction, DialNumber = 1;
    private int[] Solution = new int[3];
    private int[] Attempt = new int[3];

    private bool isRotating;
    private enum SafeNumber { One, Two, Three}
    private SafeNumber Step;
    private Vector3 ResetPosition;

    private void Awake()
    {
        ResetPosition = Dial.transform.eulerAngles;
        Solution[0] = CodeOne;
        Solution[1] = CodeTwo;
        Solution[2] = CodeThree;
        Attempt[0] = 1;
        Attempt[1] = Attempt[2] = 0;
        Step = SafeNumber.One;
        UpdateDisplay();
    }

    private void Update()
    {
        Direction = Input.GetAxisRaw("Horizontal");
        if(Input.GetButtonDown("Horizontal"))
        {
            RotateDial();
        }        
    }

    private void UpdateDisplay()
    {
        CodeDisplay.text = Attempt[0] + "|" + Attempt[1] + "|" + Attempt[2];
    }

    private void RotateDial()
    {
        Vector3 to = new Vector3(0, 0, Direction * 18.0f);
        DialNumber += Direction;
        AdjustDialNumber();
        Dial.transform.eulerAngles += to;
        UpdateAttempt();
        UpdateDisplay();
    }

    private void AdjustDialNumber()
    {
        if (DialNumber <= 0)
            DialNumber += 20;
        else if (DialNumber > 20)
            DialNumber -= 20;
    }

    //Current bug, only first number is changed, when turned left, internally counts backwards, but first turn goes positive and doesn't change till another right
    private void UpdateAttempt()
    {
        if(Step == SafeNumber.One)
        {
            if (Direction < 0)
                Step = SafeNumber.Two;
            else
                Attempt[0] = Convert.ToInt32(DialNumber);
        }
        if(Step == SafeNumber.Two)
        {
            if (Direction > 0)
                Step = SafeNumber.Three;
            else
                Attempt[1] = Convert.ToInt32(DialNumber);
        }
        if(Step == SafeNumber.Three)
        {
            if (Direction < 0)
            {
                ResetSafe();
                Step = SafeNumber.One;
            }
            else
                Attempt[2] = Convert.ToInt32(DialNumber);
        }
    }
    public void CompareSolution()
    {
        if(Attempt[0] == Solution[0] && Attempt[1] == Solution[1] && Attempt[2] == Solution[2])
        {
            DoorAnimator.SetBool("IsOpened", true);
            SafePuzzle.isComplete = true;
            SafePuzzle.DisablePuzzle();
        }
        else
        {
            //Error noise, maybe boot out of menu for reset?
            Debug.Log("Wrong Answer");
        }
    }
    public void ResetSafe()
    {
        Attempt[0] = Attempt[1] = Attempt[2] = 0;
        DialNumber = 1;
        Dial.transform.eulerAngles = ResetPosition;
    }
}
