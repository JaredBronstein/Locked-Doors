using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircuitsHack : MonoBehaviour
{

    [SerializeField] Material CenterBase;
    [SerializeField] Material CenterFalse;
    [SerializeField] Material CenterTrue;

    [SerializeField] Material TopBase;
    [SerializeField] Material TopFalse;
    [SerializeField] Material TopTrue;

    [SerializeField] Material BottomBase;
    [SerializeField] Material BottomFalse;
    [SerializeField] Material BottomTrue;

    [SerializeField] Material LeftBase;
    [SerializeField] Material LeftFalse;
    [SerializeField] Material LeftTrue;

    [SerializeField] Material RightBase;
    [SerializeField] Material RightFalse;
    [SerializeField] Material RightTrue;

    [SerializeField] Circuits RC;
    [SerializeField] Circuits LC;
    [SerializeField] Circuits TC;
    [SerializeField] Circuits BC;
    [SerializeField] Circuits CC;

    [SerializeField] GameObject LeftCirc;
    [SerializeField] GameObject RightCirc;
    [SerializeField] GameObject TopCirc;
    [SerializeField] GameObject CenterCirc;
    [SerializeField] GameObject BottomCirc;

    [SerializeField] RotatePuzzle rotpuz;

    public int TopRot;
    public int RightRot;
    public int LeftRot;
    public int BottomRot;
    public int CenterRot;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RightRot = RC.RotationNumber;
        LeftRot = LC.RotationNumber;
        CenterRot = CC.RotationNumber;
        TopRot = TC.RotationNumber;
        BottomRot = BC.RotationNumber;
        LeftSol();
        TopSol();
        RightSol();
        CenterSol();
        BottomSol();

    }

    void LeftSol()
    {
        if (LeftRot == 4)
        {
            LeftCirc.GetComponent<MeshRenderer>().material = LeftTrue;
        }

        if (LeftRot == 2)
        {
            LeftCirc.GetComponent<MeshRenderer>().material = LeftFalse;
        }

        if (LeftRot == 1 || LeftRot == 3)
        {
            LeftCirc.GetComponent<MeshRenderer>().material = LeftBase;
        }
    }

    void TopSol()
    {
        if (LeftRot == 4 && CenterRot == 2 && TopRot == 4)
        {
            TopCirc.GetComponent<MeshRenderer>().material = TopFalse;
        }

        else
        {
            TopCirc.GetComponent<MeshRenderer>().material = TopBase;
        }
    }

    void RightSol()
    {
        if (rotpuz.correctFormation == true)
            {
                RightCirc.GetComponent<MeshRenderer>().material = RightTrue;
            }
    }

    void CenterSol()
    {
        if (CenterRot == 1 && LeftRot == 4)
        {
            CenterCirc.GetComponent<MeshRenderer>().material = CenterTrue;
        }
        else if (CenterRot == 2 && LeftRot == 4)
        {
            CenterCirc.GetComponent<MeshRenderer>().material = CenterFalse;
        }
        else
        {
            CenterCirc.GetComponent<MeshRenderer>().material = CenterBase;
        }
    }

    void BottomSol()
    {
        if (CenterRot == 1 && LeftRot == 4 && BottomRot == 2)
        {
            BottomCirc.GetComponent<MeshRenderer>().material = BottomTrue;
        }
        else
        {
            BottomCirc.GetComponent<MeshRenderer>().material = BottomBase;
        }
    }

}
