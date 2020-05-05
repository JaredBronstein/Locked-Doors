using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class InventoryItemMenuToggle : MonoBehaviour
{
    [Tooltip("The image component used to show the associated object's icon.")]
    [SerializeField]
    private Image iconImage;

    public static event Action<InventoryObject> InventoryMenuItemSelected;
    public static event Action<InventoryNote> JournalMenuNoteSelected;
    private InventoryObject associatedInventoryObject;
    private InventoryNote associatedInventoryNote;
    private Text Name;

    public InventoryObject AssociatedInventoryObject
    {
        get { return associatedInventoryObject; }
        set
        {
            associatedInventoryObject = value;
            iconImage.sprite = associatedInventoryObject.Icon;
        }
    }

    public InventoryNote AssociatedInventoryNote
    {
        get { return associatedInventoryNote;  }
        set
        {
            associatedInventoryNote = value;
            iconImage.sprite = associatedInventoryNote.Icon;
            Name.text = associatedInventoryNote.ObjectName;
        }
    }

    /// <summary>
    /// This will be plugged into the toggle's "OnValueChanged" property in the editory
    /// and called whenever the toggle is clicked
    /// </summary>
    public void InventoryMenuItemWasToggled(bool isOn)
    {
        //We only want to do this when the toggle is selected.
        if (isOn)
            InventoryMenuItemSelected?.Invoke(AssociatedInventoryObject);
    }

    public void JournalMenuNoteWasToggled(bool isOn)
    {
        if (isOn)
            JournalMenuNoteSelected?.Invoke(AssociatedInventoryNote);
    }

    private void Awake()
    {
        Toggle toggle = GetComponent<Toggle>();
        ToggleGroup toggleGroup = GetComponentInParent<ToggleGroup>();
        toggle.group = toggleGroup;
        Name = GetComponentInChildren<Text>();
    }
}
