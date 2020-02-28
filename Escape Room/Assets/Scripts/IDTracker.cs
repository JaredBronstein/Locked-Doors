using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IDTracker : MonoBehaviour
{
    [SerializeField]
    private int ID = 0;

    public void ChangeID(int id)
    {
        ID = id;
    }
    public void ResetID()
    {
        ID = 0;
    }

    public bool CanInteract(int environmentID)
    {
        return (ID == environmentID);
    }
}
