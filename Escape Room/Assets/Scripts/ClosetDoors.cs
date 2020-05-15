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
        base.Awake();
        otherDoor = OtherDoor.GetComponent<ClosetDoors>();
    }

    public override void InteractWith(int ID)
    {
        if(ID == 1)
        {
            environmentIDList[0] = 0;
            otherDoor.environmentIDList[0] = 0;
            base.InteractWith(ID);
        }
    }
}
