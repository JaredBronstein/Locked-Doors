using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovableInteractiveObject : InteractiveObject
{
    [SerializeField]
    private BoxCollider HiddenItem;

    private Animator animator;
    private bool IsOpened; 
    public bool CanOpen = true;

    protected override void Awake()
    {
        base.Awake();
        animator = GetComponent<Animator>();
        if(HiddenItem != null)
            HiddenItem.enabled = false;
    }
    public override void InteractWith(int ID)
    {
        if(CanOpen)
        {
            base.InteractWith(ID);
            if (HiddenItem != null)
                HiddenItem.enabled = true;
            if (IsOpened)
                IsOpened = false;
            else if (!IsOpened)
                IsOpened = true;
            animator.SetBool("IsOpened", IsOpened);
        }
    }
}
