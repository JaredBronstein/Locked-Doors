using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotebookMenu : MonoBehaviour
{
    [SerializeField]
    private Transform noteListContentArea, todoListContentArea;

    [SerializeField]
    private GameObject main, note, todo;

    private PlayerMovement playerMovement;
    private CanvasGroup canvasGroup;
    private InventoryMenu inventoryMenu;
    private MouseLook mouseLook;

    public bool isVisible => canvasGroup.alpha > 0;

    private void Awake()
    {
        canvasGroup = GetComponent<CanvasGroup>();
        playerMovement = FindObjectOfType<PlayerMovement>();
        mouseLook = FindObjectOfType<MouseLook>();
        inventoryMenu = FindObjectOfType<InventoryMenu>();
        HideMenu();
    }

    private void Update()
    {
        HandleInput();
    }

    private void HandleInput()
    {
        if(Input.GetButtonDown("Notebook"))
        {
            if(!isVisible && !inventoryMenu.IsVisible)
            {
                ShowMenu();
            }
            else if(isVisible)
            {
                HideMenu();
            }
        }
        //Goes back to a prior menu, so if in todo list, go back to main tab, if in a specific note, go back to the note tab
        if(Input.GetButtonDown("Cancel"))
        {

        }
    }

    public void ShowMenu()
    {
        canvasGroup.alpha = 1;
        canvasGroup.interactable = true;
        playerMovement.enabled = false;
        mouseLook.enabled = false;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    private void HideMenu()
    {
        canvasGroup.alpha = 0;
        canvasGroup.interactable = false;
        playerMovement.enabled = true;
        mouseLook.enabled = true;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    /// <summary>
    /// Hides Main Notebook buttons and reveals content area for Notes
    /// </summary>
    public void OpenNoteTab()
    {

    }

    /// <summary>
    /// Hides Main Notebook buttons and reveals content area for To-Do List
    /// </summary>
    public void OpenTodoTab()
    {

    }

    /// <summary>
    /// Returns to the main Notebook tab
    /// </summary>
    private void ReturntoMain()
    {

    }
}
