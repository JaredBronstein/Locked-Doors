using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IDTracker : MonoBehaviour
{
    private int ID = 0;

    public void ChangeID(int id)
    {
        ID = id;
    }
    public void ResetID()
    {
        ID = 0;
    }

    public bool CanInteract(InteractiveObject interactiveObject)
    {
        return (ID == interactiveObject.EnvironmentID);
    }
}
