using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasManager : MonoBehaviour
{
    [SerializeField]
    private GameObject inventory, journal, hud;

    private PlayerMovement playerMovement;
    private MouseLook mouseLook;
    private CanvasGroup inventoryCanvas, journalCanvas;
    private InteractWithLookedAt interactWithLookedAt;

    public bool canUse = true;

    private void Awake()
    {
        playerMovement = FindObjectOfType<PlayerMovement>();
        mouseLook = FindObjectOfType<MouseLook>();
        interactWithLookedAt = FindObjectOfType<InteractWithLookedAt>();
        hud.SetActive(true);
        inventoryCanvas = inventory.GetComponent<CanvasGroup>();
        journalCanvas = journal.GetComponent<CanvasGroup>();
        inventoryCanvas.alpha = 0;
        inventoryCanvas.interactable = false;
        inventoryCanvas.blocksRaycasts = false;
        journalCanvas.alpha = 0;
        journalCanvas.interactable = false;
        journalCanvas.blocksRaycasts = false;
    }

    private void Update()
    {
        if(canUse)
        {
            if (Input.GetButtonDown("Inventory"))
            {
                ToggleInventory();
            }
            if (Input.GetButtonDown("Notebook"))
            {
                ToggleJournal();
            }
            if (Input.GetButtonDown("Cancel"))
            {
                playerMovement.enabled = true;
                mouseLook.enabled = true;
                interactWithLookedAt.enabled = true;
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
                hud.SetActive(true);
                inventoryCanvas.alpha = 0;
                inventoryCanvas.interactable = false;
                inventoryCanvas.blocksRaycasts = false;
                journalCanvas.alpha = 0;
                journalCanvas.interactable = false;
                journalCanvas.blocksRaycasts = false;
            }
        }
    }

    public void ToggleInventory()
    {
        if (inventoryCanvas.interactable)
        {
            playerMovement.enabled = true;
            mouseLook.enabled = true;
            interactWithLookedAt.enabled = true;
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            hud.SetActive(true);
            inventoryCanvas.alpha = 0;
            inventoryCanvas.interactable = false;
            inventoryCanvas.blocksRaycasts = false;
            journalCanvas.alpha = 0;
            journalCanvas.interactable = false;
            journalCanvas.blocksRaycasts = false;
        }
        else
        {
            playerMovement.enabled = false;
            mouseLook.enabled = false;
            interactWithLookedAt.enabled = false;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            hud.SetActive(false);
            inventoryCanvas.alpha = 1;
            inventoryCanvas.interactable = true;
            inventoryCanvas.blocksRaycasts = true;
            journalCanvas.alpha = 0;
            journalCanvas.interactable = false;
            journalCanvas.blocksRaycasts = false;
            journalCanvas.blocksRaycasts = false;
        }
    }
    public void ToggleJournal()
    {
        if (journalCanvas.interactable)
        {
            playerMovement.enabled = true;
            mouseLook.enabled = true;
            interactWithLookedAt.enabled = false;
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            hud.SetActive(true);
            inventoryCanvas.alpha = 0;
            inventoryCanvas.interactable = false;
            inventoryCanvas.blocksRaycasts = false;
            journalCanvas.alpha = 0;
            journalCanvas.interactable = false;
            journalCanvas.blocksRaycasts = false;
        }
        else
        {
            playerMovement.enabled = false;
            mouseLook.enabled = false;
            interactWithLookedAt.enabled = false;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            hud.SetActive(false);
            inventoryCanvas.alpha = 0;
            inventoryCanvas.interactable = false;
            inventoryCanvas.blocksRaycasts = false;
            journalCanvas.alpha = 1;
            journalCanvas.interactable = true;
            journalCanvas.blocksRaycasts = true;
        }
    }
}
