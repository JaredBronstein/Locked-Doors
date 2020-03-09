﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryNote : InteractiveObject
{
    [Tooltip("The name of the note, as it appears in the Journal menu")]
    [SerializeField]
    private string objectName = nameof(InventoryObject);

    [Tooltip("The text that will display when the player selects this object in the Journal menu")]
    [TextArea(3, 8)]
    [SerializeField]
    private string description;

    [Tooltip("Icon to display for this item in the inventory menu")]
    [SerializeField]
    private Sprite icon;

    public Sprite Icon => icon;
    public string Description => description;
    public string ObjectName => objectName;

    private new Renderer renderer;
    private new Collider collider;
    private new BoxCollider boxCollider;

    private void Start()
    {
        renderer = GetComponent<Renderer>();
        collider = GetComponent<Collider>();
        boxCollider = GetComponent<BoxCollider>();
    }

    public InventoryNote()
    {
        displayText = $"Take {objectName}";
    }

    public override void InteractWith(int ID)
    {
        base.InteractWith(ID);
        PlayerInventory.InventoryNotes.Add(this);
        JournalMenu.Instance.AddNoteToJournal(this);
        renderer.enabled = false;
        collider.enabled = false;
        boxCollider.enabled = false;
    }
}
