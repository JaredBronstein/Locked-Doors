using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IDTracker : MonoBehaviour
{
    [SerializeField]
    private int ID = 0;

    private bool Bool;

    public void ChangeID(int id)
    {
        ID = id;
    }
    public void ResetID()
    {
        ID = 0;
    }

    public bool CanInteract(int[] environmentIDs)
    {
        foreach(int id in environmentIDs)
        {
            if(id == ID)
            {
                return true;
            }
        }
        return false;
    }
    public int GetID()
    {
        return ID;
    }
}
