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

    public int scale1Line, scale2Line, scale3Line;
    float scale1InitialHeight, scale2InitialHeight, scale3InitialHeight;
    private bool isComplete;

    // Start is called before the first frame update
    void Awake()
    {
        interactivePuzzle = GetComponent<InteractivePuzzle>();

        Scale1T = Scale1.GetComponent<Transform>();
        Scale2T = Scale2.GetComponent<Transform>();
        Scale3T = Scale3.GetComponent<Transform>();

        scale1InitialHeight = Scale1T.position.y;
        scale2InitialHeight = Scale2T.position.y - 0.2f;
        scale3InitialHeight = Scale3T.position.y;

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
        UpdateScales();
    }

    private void UpdateScales()
    {
        Vector3 startPosition1, startPosition2, startPosition3;
        Vector3 endPosition1, endPosition2, endPosition3;

        //Scale 1
        startPosition1 = Scale1T.position;
        endPosition1 = new Vector3(Scale1T.position.x, scale1InitialHeight + 0.1f * (scale1Line - 1), Scale1T.position.z);

        //Scale 2
        startPosition2 = Scale2T.position;
        endPosition2 = new Vector3(Scale2T.position.x, scale2InitialHeight + 0.1f * (scale2Line - 1), Scale2T.position.z);

        //Scale 3
        startPosition3 = Scale3T.position;
        endPosition3 = new Vector3(Scale3T.position.x, scale3InitialHeight + 0.1f * (scale3Line - 1), Scale3T.position.z);

        for (int i = 1; i <= 10; i++)
        {
            Scale1T.position = Vector3.Lerp(startPosition1, endPosition1, i / 10);
            Scale2T.position = Vector3.Lerp(startPosition2, endPosition2, i / 10);
            Scale3T.position = Vector3.Lerp(startPosition3, endPosition3, i / 10);
        }
    }

    private void Update()
    {
        if (scale1Line == 3 && scale2Line == 3 && scale3Line == 3)
        {
            interactivePuzzle.isComplete = true;
            interactivePuzzle.DisablePuzzle();
            interactivePuzzle.GiveItem();
        }
    }
}
