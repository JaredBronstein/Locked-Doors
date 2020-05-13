using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WineBottle : InteractiveObject
{
    [SerializeField]
    private GameObject BrokenBottle, IntactBottle;

    protected override void Awake()
    {
        base.Awake();
        BrokenBottle.SetActive(false);
    }

    public override void InteractWith(int id)
    {
        base.InteractWith(id);
        IntactBottle.SetActive(false);
        BrokenBottle.SetActive(true);
    }
}
