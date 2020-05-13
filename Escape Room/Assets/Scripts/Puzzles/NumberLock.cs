using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberLock : MonoBehaviour
{
    [SerializeField]
    private int[] Solution = new int[3];

    [SerializeField]
    private GameObject DialOne, DialTwo, DialThree;

    [SerializeField]
    private GameObject LockedObject;

    private int[] Attempt = new int[3];
    private InteractivePuzzle LockPuzzle;

    private void Awake()
    {
        Attempt[0] = Attempt[1] = Attempt[2] = 6;
        LockPuzzle = GetComponent<InteractivePuzzle>();
        LockedObject.GetComponent<BoxCollider>().enabled = false;
    }

    public void RotateDial(int Number)
    {
        if (Number == 1)
        {
            Vector3 to = new Vector3(0, 36.0f, 0);
            DialOne.transform.eulerAngles += to;
            Attempt[0]++;
        }
        else if (Number == 2)
        {
            Vector3 to = new Vector3(0, 36.0f, 0);
            DialTwo.transform.eulerAngles += to;
            Attempt[1]++;
        }
        else if (Number == 3)
        {
            Vector3 to = new Vector3(0, 36.0f, 0);
            DialThree.transform.eulerAngles += to;
            Attempt[2]++;
        }
        AdjustNumbers();
        CompareSolution();
    }

    private void CompareSolution()
    {
        if(Attempt[0] == Solution[0] && Attempt[1] == Solution[1] && Attempt[2] == Solution[2])
        {
            LockPuzzle.isComplete = true;
            LockPuzzle.DisablePuzzle();
            this.gameObject.SetActive(false);
            LockedObject.GetComponent<BoxCollider>().enabled = true;
        }
    }

    private void AdjustNumbers()
    {
        for(int i= 0; i<Attempt.Length; i++)
        {
            if(Attempt[i] > 9)
            {
                Attempt[i] -= 10;
            }
            else if(Attempt[i] < 0)
            {
                Attempt[i] += 10;
            }
        }
    }
}

