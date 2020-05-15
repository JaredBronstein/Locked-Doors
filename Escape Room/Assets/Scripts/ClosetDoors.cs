using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosetDoors : MovableInteractiveObject
{
    [SerializeField]
    private GameObject OtherDoor;

    private ClosetDoors otherDoor;

    protected override void Awake()
    {
        otherDoor = OtherDoor.GetComponent<ClosetDoors>();
    }

    public override void InteractWith(int ID)
    {
        if(ID == 1)
        {
            base.InteractWith(ID);
            environmentIDList[0] = 0;
            otherDoor.environmentIDList[0] = 0;
        }
    }
}
