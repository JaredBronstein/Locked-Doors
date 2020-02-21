using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveObject : MonoBehaviour, IInteractive
{
    [Tooltip("Text that will display in the UI when the player looks at this object in the world")]
    [SerializeField]
    protected string displayText = nameof(InteractiveObject);

    [Tooltip("Number used in the inventory to determine it's ID number.")]
    [SerializeField]
    protected int inventoryID;

    [Tooltip("Number used in the environment to determine it's ID number. Zero means it can be interacted with without an object in hand")]
    [SerializeField]
    protected int environmentID;

    public virtual string DisplayText => displayText;
    public int InventoryID => inventoryID;
    public int EnvironmentID => environmentID;
    protected AudioSource audioSource;

    protected virtual void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public virtual void InteractWith()
    {
        try
        {
            audioSource.Play();
        }
        catch (System.Exception)
        {

            throw new System.Exception("Missing AudioSource component: InteractiveObject requires an AudioSource component");
        }
        Debug.Log($"Player just interacted with {gameObject.name}.");
    }
}
