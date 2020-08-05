using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveObject : MonoBehaviour, IInteractive
{
    [Tooltip("Text that will display in the UI when the player looks at this object in the world")]
    [SerializeField]
    protected string displayText = nameof(InteractiveObject);

    [Tooltip("Text displayed when the player observes the object in the world")]
    [TextArea(3, 8)]
    [SerializeField]
    protected string observationText;

    [Tooltip("Number used in the inventory to determine it's ID number.")]
    [SerializeField]
    protected int inventoryID;

    [Tooltip("Number used in the environment to determine it's ID number. Zero means it can be interacted with without an object in hand and 100 means it will be overwritten")]
    [SerializeField]
    protected int[] environmentIDList;

    [Tooltip("True if it removes the object used to activate from the inventory, false if otherwise")]
    [SerializeField]
    protected bool TakesObject;

    public virtual string DisplayText => displayText;
    public virtual string ObservationText => observationText;
    public int InventoryID => inventoryID;
    public int[] EnvironmentIDs => environmentIDList;
    protected AudioSource audioSource;
    protected InventoryMenu inventoryMenu;

    protected virtual void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        inventoryMenu = GetComponent<InventoryMenu>();
    }

    public virtual void InteractWith(int id)
    {
        if(audioSource != null)
            audioSource.Play();
        if (TakesObject && id != 0)
            inventoryMenu.RemoveItemInMenu(id);
        Debug.Log($"Player just interacted with {gameObject.name}.");
    }
    public virtual int[] ID()
    {
        return environmentIDList;
    }
}
