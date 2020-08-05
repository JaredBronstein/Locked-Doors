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
    private IDTracker playerID;
    private HUDController HUDcontroller;
    private InventoryItem ActiveInventoryObject;
    private HotbarMenu hotbarMenu;
    private CanvasManager canvasManager;

    private InventoryItemMenuToggle[] inventoryObjects;

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
    public void AddItemToMenu(InventoryItem inventoryObjectToAdd)
    {
        GameObject clone = Instantiate(inventoryMenuItemTogglePrefab, inventoryListContentArea);
        InventoryItemMenuToggle toggle = clone.GetComponent<InventoryItemMenuToggle>();
        toggle.AssociatedInventoryItem = inventoryObjectToAdd;
    }

    /// <summary>
    /// Searches for an InventoryMenuItemToggle that contains the correct ID and removes it from the inventory
    /// </summary>
    /// <param name="InventoryID">The ID to the item intended to be deleted</param>
    public void RemoveItemInMenu(int InventoryID)
    {
        inventoryObjects = GetComponentsInChildren<InventoryItemMenuToggle>();
        foreach (InventoryItemMenuToggle inventoryObject in inventoryObjects)
        {
            if (inventoryObject.ObjectIDCheck(InventoryID))
            {
                hotbarMenu.CheckForDeletion(inventoryObject);
                Destroy(inventoryObject.gameObject);
            }
        }
    }

    /// <summary>
    /// This is the event handler for InventoryMenuItemSelected.
    /// </summary>
    private void OnInventoryMenuItemSelected(InventoryItem inventoryObjectThatWasSelected)
    {
        if (inventoryObjectThatWasSelected != null)
        {
            itemLabelText.text = inventoryObjectThatWasSelected.ObjectName;
            descriptionAreaText.text = inventoryObjectThatWasSelected.Description;
            playerID.ChangeID(inventoryObjectThatWasSelected.InventoryID);
            HUDcontroller.ImageSwap(inventoryObjectThatWasSelected.Icon);
        }
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
        playerID = FindObjectOfType<IDTracker>();
        HUDcontroller = FindObjectOfType<HUDController>();
        canvasManager = FindObjectOfType<CanvasManager>();
        hotbarMenu = FindObjectOfType<HotbarMenu>();
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
    private void Update()
    {
        //for setting quick select
        if (canvasManager.canvasState == CanvasManager.CanvasState.Inventory)
        {
            if (Input.GetButtonDown("QuickSelect1"))
            {
                if (ActiveInventoryObject != null)
                {
                    hotbarMenu.SetQuickSelect(0, ActiveInventoryObject);
                }
            }
            else if (Input.GetButtonDown("QuickSelect2"))
            {
                if (ActiveInventoryObject != null)
                {
                    hotbarMenu.SetQuickSelect(1, ActiveInventoryObject);
                }
            }
            else if (Input.GetButtonDown("QuickSelect3"))
            {
                if (ActiveInventoryObject != null)
                {
                    hotbarMenu.SetQuickSelect(2, ActiveInventoryObject);
                }
            }
            else if (Input.GetButtonDown("QuickSelect4"))
            {
                if (ActiveInventoryObject != null)
                {
                    hotbarMenu.SetQuickSelect(3, ActiveInventoryObject);
                }
            }
            else if (Input.GetButtonDown("QuickSelect5"))
            {
                if (ActiveInventoryObject != null)
                {
                    hotbarMenu.SetQuickSelect(4, ActiveInventoryObject);
                }
            }
        }
        //For grabbing quick select
        else if (canvasManager.canvasState == CanvasManager.CanvasState.None)
        {
            if (Input.GetButtonDown("QuickSelect1"))
            {
                OnInventoryMenuItemSelected(hotbarMenu.GetQuickSelect(0));
            }
            else if (Input.GetButtonDown("QuickSelect2"))
            {
                OnInventoryMenuItemSelected(hotbarMenu.GetQuickSelect(1));
            }
            else if (Input.GetButtonDown("QuickSelect3"))
            {
                OnInventoryMenuItemSelected(hotbarMenu.GetQuickSelect(2));
            }
            else if (Input.GetButtonDown("QuickSelect4"))
            {
                OnInventoryMenuItemSelected(hotbarMenu.GetQuickSelect(3));
            }
            else if (Input.GetButtonDown("QuickSelect5"))
            {
                OnInventoryMenuItemSelected(hotbarMenu.GetQuickSelect(4));
            }
        }
    }
}
