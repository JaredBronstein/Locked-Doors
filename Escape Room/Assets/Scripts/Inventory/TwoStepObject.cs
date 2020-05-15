using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoStepObject : InteractiveObject
{
    [SerializeField]
    private GameObject State1, State2, Pickup;

    protected override void Awake()
    {
        base.Awake();
        State2.SetActive(false);
        Pickup.SetActive(false);
    }

    public override void InteractWith(int id)
    {
        base.InteractWith(id);
        State1.SetActive(false);
        State2.SetActive(true);
        Pickup.SetActive(true);
    }
}
