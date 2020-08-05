using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HotbarMenu : MonoBehaviour
{
    [SerializeField]
    private Image[] quickSelectImages = new Image[5];

    [SerializeField]
    private Sprite PlaceholderImage;

    private InventoryItem[] quickSelectItems = new InventoryItem[5];

    /// <summary>
    /// Sets the hotbar object to a pre-existing inventory item. If the hotbar item is the same as the item being called then set to Placeholder
    /// </summary>
    /// <param name="number">The hotbar number position</param>
    /// <param name="inventoryObject">The inventory item being called</param>
    public void SetQuickSelect(int number, InventoryItem inventoryObject)
    {
        if (quickSelectImages[number].sprite != inventoryObject.Icon)
        {
            quickSelectImages[number].sprite = inventoryObject.Icon;
            quickSelectItems[number] = inventoryObject;
        }
        else
        {
            quickSelectImages[number].sprite = PlaceholderImage;
            quickSelectItems[number] = null;
        }
        for (int i = 0; i < quickSelectImages.Length; i++)
        {
            if (i != number)
            {
                if (quickSelectImages[i].sprite == inventoryObject.Icon)
                {
                    quickSelectImages[i].sprite = PlaceholderImage;
                    quickSelectItems[i] = null;
                }
            }

        }
    }
    public InventoryItem GetQuickSelect(int number)
    {
        if (quickSelectItems[number] == null)
            return null;
        else
            return quickSelectItems[number];
    }

    /// <summary>
    /// Called when an item is removed from the inventory to see if it's present in the quick select, if so that spot is empty
    /// </summary>
    /// <param name="inventoryItemMenuToggle">The item being deleted</param>
    public void CheckForDeletion(InventoryItemMenuToggle inventoryItemMenuToggle)
    {
        for (int i = 0; i < quickSelectItems.Length; i++)
        {
            if (quickSelectItems[i] == inventoryItemMenuToggle.AssociatedInventoryItem)
            {
                quickSelectItems[i] = null;
                quickSelectImages[i].sprite = PlaceholderImage;
            }
        }
    }
}