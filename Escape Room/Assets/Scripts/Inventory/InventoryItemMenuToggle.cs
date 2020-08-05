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

    public static event Action<InventoryItem> InventoryMenuItemSelected, JournalMenuItemSelected, HotbarMenuItemSelected;
    private InventoryItem associatedInventoryItem;
    private Text name;

    public InventoryItem AssociatedInventoryItem
    {
        get { return associatedInventoryItem; }
        set
        {
            associatedInventoryItem = value;
            iconImage.sprite = associatedInventoryItem.Icon;
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
        {
            if (AssociatedInventoryItem == null) ;

            else if (AssociatedInventoryItem.IsCorrectState(0))
                InventoryMenuItemSelected?.Invoke(AssociatedInventoryItem);
            else if (AssociatedInventoryItem.IsCorrectState(2))
                JournalMenuItemSelected?.Invoke(AssociatedInventoryItem);
        }
    }

    private void Awake()
    {
        Toggle toggle = GetComponent<Toggle>();
        ToggleGroup toggleGroup = GetComponentInParent<ToggleGroup>();
        toggle.group = toggleGroup;
    }

    public bool ObjectIDCheck(int ID)
    {
        return associatedInventoryItem.InventoryID == ID;
    }


    /// <summary>
    /// Called whenever something needs to check if you have a certain item in your inventory. Essentially checks the associated object
    /// and returns the Dialogue Bool name if there is one
    /// </summary>
    /// <returns>The name of the bool used in the dialogue system</returns>
    public string ObjectDialogueBoolCheck()
    {
        if (associatedInventoryItem.DialogueBoolName != null)
            return associatedInventoryItem.DialogueBoolName;
        else
            return null;
    }
}
