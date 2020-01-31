using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScalesPuzzle : MonoBehaviour
{

    [SerializeField]
    GameObject Scale1, Scale2, Scale3;

    Transform Scale1T, Scale2T, Scale3T;

    public int scale1Line, scale2Line, scale3Line;
    bool goingDown1, goingDown2, goingDown3;

    // Start is called before the first frame update
    void Awake()
    {
        Scale1T = Scale1.GetComponent<Transform>();
        Scale2T = Scale2.GetComponent<Transform>();
        Scale3T = Scale3.GetComponent<Transform>();

        scale1Line = 5;
        scale2Line = 3;
        scale3Line = 5;

        goingDown1 = true;
        goingDown2 = false;
        goingDown3 = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MoveScales(int whichOne)
    {
        switch (whichOne)
        {
            case 1:
                if (scale1Line != 1)
                {
                    scale1Line -= 1;

                    if (scale2Line != 5)
                        scale2Line += 1;
                    else
                        scale2Line -= 1;

                    if (scale3Line != 5)
                        scale3Line += 1;
                    else
                        scale3Line -= 1;
                }
                break;

            case 2:
                if (scale2Line != 1)
                {
                    //scale 2
                    scale2Line -= 2;

                    if (scale2Line < 1)
                        scale2Line = 1;

                    //scale 1
                    if (scale1Line != 5)
                        scale1Line += 2;
                    else
                        scale1Line -= 2;

                    if (scale1Line > 5)
                        scale1Line = 5 - (scale1Line - 5);
                    else if (scale1Line < 1)
                        scale1Line = 1;
                    
                    //scale 3
                    if (scale3Line != 5)
                        scale3Line += 1;
                    else
                        scale3Line -= 1;

                    if (scale3Line > 5)
                        scale3Line = 5 - (scale3Line - 5);
                    else if (scale3Line < 1)
                        scale3Line = 1;
                }
                break;

            case 3:
                if (scale3Line != 1)
                {
                    //third scale
                    scale3Line -= 3;

                    if (scale3Line < 1)
                        scale3Line = 1;


                    //scale 2
                    if (scale2Line != 5)
                        scale2Line += 3;
                    else
                        scale2Line -= 3;

                    if (scale2Line > 5)
                        scale2Line = 5 - (scale2Line - 5);
                    else if (scale2Line < 1)
                        scale2Line = 1;

                    //scale 3
                    if (scale1Line != 5)
                        scale1Line += 3;
                    else
                        scale1Line -= 3;

                    if (scale1Line > 5)
                        scale1Line = 5 - (scale1Line - 5);
                    else if (scale1Line < 1)
                        scale1Line = 1;
                }
                break;
        }
    }
}
