using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovableInteractiveObject : InteractiveObject
{
    private Animator animator;
    private bool IsOpened;

    protected override void Awake()
    {
        base.Awake();
        animator = GetComponent<Animator>();
    }
    public override void InteractWith(int ID)
    {
        base.InteractWith(ID);
        if (IsOpened)
            IsOpened = false;
        else if(!IsOpened)
            IsOpened = true;
        animator.SetBool("IsOpened", IsOpened);
    }
}
