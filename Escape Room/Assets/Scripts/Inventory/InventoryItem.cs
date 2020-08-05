using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The purpose of this class is to serve as a parent class for InventoryObject. The difference between them is InventoryObject
/// has functionality for reference to tangible, viewable objects in the scene whereas this just handles the inventory part
/// This is mainly so I can 
/// </summary>
public class InventoryItem : InteractiveObject
{
    protected enum ObjectState { Item, Note};

    [Tooltip("The name of the object, as it will appear in the inventory menu UI")]
    [SerializeField]
    protected string objectName = nameof(InventoryItem);

    [Tooltip("The text that will display when the player selects this object in the inventory menu")]
    [TextArea(3, 8)]
    [SerializeField]
    protected string description;

    [Tooltip("Icon to display for this item in the inventory menu")]
    [SerializeField]
    protected Sprite icon;

    public Sprite Icon => icon;
    public string Description => description;
    public string ObjectName => objectName;

    [Tooltip("String used to change Dialogue System booleans, leave blank if none must be changed")]
    public string DialogueBoolName;

    [Tooltip("Determines where this object goes when added to your inventory.")]
    [SerializeField]
    protected ObjectState objectState;

    private JournalGoal journalGoal;

    public InventoryItem()
    {
        displayText = $"Take {objectName}";
    }

    public override void InteractWith(int id)
    {
        base.InteractWith(id);
        if (objectState == ObjectState.Item)
        {
            PlayerInventory.InventoryObjects.Add(this);
            InventoryMenu.Instance.AddItemToMenu(this);
        }
        else if (objectState == ObjectState.Note)
        {
            PlayerInventory.InventoryNotes.Add(this);
            JournalMenu.Instance.AddNoteToJournal(this);
        }
        if (this.GetComponent<JournalGoal>() != null)
            journalGoal.AddGoal();
    }
    public bool IsCorrectState(int State)
    {
        switch (State)
        {
            case 0: return objectState == ObjectState.Item;
            case 1: return objectState == ObjectState.Note;
            default: return false;
        }
    }
}
