using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public static List<InventoryItem> InventoryObjects { get; } = new List<InventoryItem>();
    public static List<InventoryItem> InventoryNotes { get; } = new List<InventoryItem>();
}
