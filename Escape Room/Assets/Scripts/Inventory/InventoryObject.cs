using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The tangible add-on to the inventory item script. This is just to deal with the physical object when interacted with
/// </summary>
public class InventoryObject : InventoryItem
{
    protected new Renderer renderer;
    protected new Collider collider;
    protected new BoxCollider boxCollider;
    protected JournalGoal journalGoal;

    private void Start()
    {
        renderer = GetComponent<Renderer>();
        collider = GetComponent<Collider>();
        boxCollider = GetComponent<BoxCollider>();
        journalGoal = GetComponent<JournalGoal>();
    }

    public override void InteractWith(int id)
    {
        base.InteractWith(id);
        renderer.enabled = false;
        collider.enabled = false;
        boxCollider.enabled = false;
    }
}