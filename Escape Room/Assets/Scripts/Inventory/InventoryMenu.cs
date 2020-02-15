using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryMenu : MonoBehaviour
{
    [SerializeField]
    private GameObject inventoryMenuItemTogglePrefab;

    [Tooltip("Content of the scrollview for the list of inventory items.")]
    [SerializeField]
    private Transform inventoryListContentArea;

    [Tooltip("Place in the UI for displaying the name of the selected inventory item")]
    [SerializeField]
    private Text itemLabelText;

    [Tooltip("Place in the UI for displaying info about the selected inventory item")]
    [SerializeField]
    private Text descriptionAreaText;

    private static InventoryMenu instance;
    private AudioSource audioSource;

    public static InventoryMenu Instance
    {
        get
        {
            if (instance == null)
                throw new System.Exception("There is currently no InventoryMenu instance, but you are trying to access it! Makes sure the InventoryMenu script is attached to something in the scene!");
            return instance;
        }
        private set { instance = value; }
    }

    /// <summary>
    /// Instantiates a new InventoryMenuItemToggle prefab and adds it to the menu
    /// </summary>
    /// <param name="inventoryObjectToAdd"></param>
    public void AddItemToMenu(InventoryObject inventoryObjectToAdd)
    {
        GameObject clone = Instantiate(inventoryMenuItemTogglePrefab, inventoryListContentArea);
        InventoryItemMenuToggle toggle = clone.GetComponent<InventoryItemMenuToggle>();
        toggle.AssociatedInventoryObject = inventoryObjectToAdd;
    }

    /// <summary>
    /// This is the event handler for InventoryMenuItemSelected.
    /// </summary>
    private void OnInventoryMenuItemSelected(InventoryObject inventoryObjectThatWasSelected)
    {
        itemLabelText.text = inventoryObjectThatWasSelected.ObjectName;
        descriptionAreaText.text = inventoryObjectThatWasSelected.Description;
    }

    private void OnEnable()
    {
        InventoryItemMenuToggle.InventoryMenuItemSelected += OnInventoryMenuItemSelected;
    }

    private void OnDisable()
    {
        InventoryItemMenuToggle.InventoryMenuItemSelected -= OnInventoryMenuItemSelected;
    }
    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            throw new System.Exception("There is already an instance of InventoryMenu and there can only be one!");

        audioSource = GetComponent<AudioSource>();
    }
    private void Start()
    {
        StartCoroutine(WaitForAudioClip());
    }

    private IEnumerator WaitForAudioClip()
    {
        float ogVolume = audioSource.volume;
        audioSource.volume = 0;
        yield return new WaitForSeconds(audioSource.clip.length);
        audioSource.volume = ogVolume;
    }
}
