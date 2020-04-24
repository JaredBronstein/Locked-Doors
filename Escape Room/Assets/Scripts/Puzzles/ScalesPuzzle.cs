using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Created By Jonathan Way, Edited by Jared Bronstein
public class ScalesPuzzle : MonoBehaviour
{

    [SerializeField]
    GameObject Scale1, Scale2, Scale3;

    private InteractivePuzzle interactivePuzzle;

    Transform Scale1T, Scale2T, Scale3T;
    private Animator Scale1Animator, Scale2Animator, Scale3Animator;

    public int scale1Line, scale2Line, scale3Line;
    private bool isComplete;

    void Awake()
    {
        interactivePuzzle = GetComponent<InteractivePuzzle>();

        Scale1T = Scale1.GetComponent<Transform>();
        Scale2T = Scale2.GetComponent<Transform>();
        Scale3T = Scale3.GetComponent<Transform>();

        Scale1Animator = Scale1.GetComponent<Animator>();
        Scale2Animator = Scale2.GetComponent<Animator>();
        Scale3Animator = Scale3.GetComponent<Animator>();

        scale1Line = 1;
        scale2Line = 3;
        scale3Line = 1;
    }

    public void MoveScales(int whichOne)
    {
        switch (whichOne)
        {
            case 1:
                if (scale1Line > 1)
                {
                    scale1Line -= 1;

                    if (scale2Line < 5)
                        scale2Line += 1;
                    else
                        scale2Line -= 1;

                    if (scale3Line < 5)
                        scale3Line += 1;
                    else
                        scale3Line -= 1;
                }
                break;

            case 2:
                if (scale2Line > 1)
                {
                    //scale 2
                    scale2Line -= 2;

                    if (scale2Line < 1)
                        scale2Line = 1;

                    //scale 1
                    if (scale1Line < 5)
                        scale1Line += 2;
                    else
                        scale1Line -= 2;

                    if (scale1Line > 5)
                        scale1Line = 10 - scale1Line;
                    else if (scale1Line < 1)
                        scale1Line = 1;
                    
                    //scale 3
                    if (scale3Line < 5)
                        scale3Line += 2;
                    else
                        scale3Line -= 2;

                    if (scale3Line > 5)
                        scale3Line = 10 - scale3Line;
                    else if (scale3Line < 1)
                        scale3Line = 1;
                }
                break;

            case 3:
                if (scale3Line > 1)
                {
                    //third scale
                    scale3Line -= 3;

                    if (scale3Line < 1)
                        scale3Line = 1;


                    //scale 2
                    if (scale2Line < 5)
                        scale2Line += 3;
                    else
                        scale2Line -= 3;

                    if (scale2Line > 5)
                        scale2Line = 10 - scale2Line;
                    else if (scale2Line < 1)
                        scale2Line = 1;

                    //scale 3
                    if (scale1Line < 5)
                        scale1Line += 3;
                    else
                        scale1Line -= 3;

                    if (scale1Line > 5)
                        scale1Line = 10 - scale1Line;
                    else if (scale1Line < 1)
                        scale1Line = 1;
                }
                break;
        }
    }

    private void UpdateScales()
    {
        Scale1Animator.SetInteger("Position", scale1Line);
        Scale2Animator.SetInteger("Position", scale2Line);
        Scale3Animator.SetInteger("Position", scale3Line);
    }

    private void Update()
    {
        UpdateScales();
        if (scale1Line == 3 && scale2Line == 3 && scale3Line == 3)
        {
            interactivePuzzle.isComplete = true;
            interactivePuzzle.DisablePuzzle();
            interactivePuzzle.GiveItem();
        }
    }
}
