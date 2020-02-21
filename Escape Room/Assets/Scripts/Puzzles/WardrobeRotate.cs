using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WardrobeRotate : MonoBehaviour
{

    [SerializeField]
    GameObject Key;

    [SerializeField]
    int resetX, resetY, resetZ;

    [SerializeField]
    GameObject[] Pieces;

    Transform thisTransform;

    int wayToSpin;

    private void Awake()
    {
        wayToSpin = 0;
    }

    void Update()
    {
        ConstantRotation(wayToSpin);
    }

    private void ConstantRotation(int whichWay)
    {
        for(int i = 0; i < Pieces.Length; i++)
        {
            thisTransform = Pieces[i].GetComponent<Transform>();
            thisTransform.Rotate(0,0,whichWay);
        }
    }

    public void WhichWay(int Input)
    {
        if (Input == 1)
            wayToSpin = 1;
        else if (Input == -1)
            wayToSpin = -1;
    }

    public void ResetKey()
    {
        thisTransform = Key.GetComponent<Transform>();
        thisTransform.position = new Vector3(resetX, resetY, resetZ);
    }
}
