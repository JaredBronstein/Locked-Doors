using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JournalMenu : MonoBehaviour
{
    [SerializeField]
    private Transform noteListContentArea, todoListContentArea;

    [SerializeField]
    private GameObject NotePrefab, mainPanel, notePanel, todoPanel;

    [SerializeField]
    private Text noteSpace;

    private CanvasGroup mainCanvas, noteCanvas, todoCanvas;

    private PlayerMovement playerMovement;
    private InventoryMenu inventoryMenu;
    private MouseLook mouseLook;
    private static JournalMenu instance;

    public static JournalMenu Instance
    {
        get
        {
            if (instance == null)
                throw new System.Exception("There is currently no JournalMenu instance, but you are trying to access it! Makes sure the JournalMenu script is attached to something in the scene!");
            return instance;
        }
        private set { instance = value; }
    }


    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            throw new System.Exception("There is already an instance of InventoryMenu and there can only be one!");

        inventoryMenu = FindObjectOfType<InventoryMenu>();
        mainCanvas = mainPanel.GetComponent<CanvasGroup>();
        noteCanvas = notePanel.GetComponent<CanvasGroup>();
        todoCanvas = todoPanel.GetComponent<CanvasGroup>();
        ReturntoMain();
    }

    private void Update()
    {
        HandleInput();
    }

    private void HandleInput()
    {
        //Goes back to a prior menu, so if in todo list, go back to main tab, if in a specific note, go back to the note tab
        if(Input.GetButtonDown("Back"))
        {
            ReturntoMain();
        }
    }

    /// <summary>
    /// Hides Main Notebook buttons and reveals content area for Notes
    /// </summary>
    public void OpenNoteTab()
    {
        mainCanvas.alpha = 0;
        mainCanvas.interactable = false;
        mainCanvas.blocksRaycasts = false;
        noteCanvas.alpha = 1;
        noteCanvas.interactable = true;
        noteCanvas.blocksRaycasts = true;
    }

    /// <summary>
    /// Hides Main Notebook buttons and reveals content area for To-Do List
    /// </summary>
    public void OpenTodoTab()
    {
        mainCanvas.alpha = 0;
        mainCanvas.interactable = false;
        mainCanvas.blocksRaycasts = false;
        todoCanvas.alpha = 1;
        todoCanvas.interactable = true;
        todoCanvas.blocksRaycasts = true;
    }

    /// <summary>
    /// Returns to the main Notebook tab
    /// </summary>
    private void ReturntoMain()
    {
        todoCanvas.alpha = 0;
        todoCanvas.interactable = false;
        todoCanvas.blocksRaycasts = false;
        noteCanvas.alpha = 0;
        noteCanvas.interactable = false;
        noteCanvas.blocksRaycasts = false;
        mainCanvas.alpha = 1;
        mainCanvas.interactable = true;
        mainCanvas.blocksRaycasts = true;
    }

    public void AddNoteToJournal(InventoryNote NoteToAdd)
    {
        GameObject Clone = Instantiate(NotePrefab, noteListContentArea);
        InventoryItemMenuToggle toggle = Clone.GetComponent<InventoryItemMenuToggle>();
        toggle.AssociatedInventoryNote = NoteToAdd;
    }

    private void OnEnable()
    {
        InventoryItemMenuToggle.JournalMenuNoteSelected += OnJournalMenuNoteSelected;
    }

    private void OnDisable()
    {
        InventoryItemMenuToggle.JournalMenuNoteSelected -= OnJournalMenuNoteSelected;
    }

    private void OnJournalMenuNoteSelected(InventoryNote inventoryNoteSelected)
    {
        noteSpace.text = inventoryNoteSelected.Description;
    }

    public void AddToDoToJournal()
    {

    }
}
