using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractivePuzzle : InteractiveObject
{
    [SerializeField]
    private Canvas PuzzleCanvas;
    [SerializeField]
    private Camera PuzzleCamera, PlayerCamera;
    [Tooltip("Item rewarded upon completion of the puzzle. Applies only to puzzles that put the item directly in the inventory. Leave empty if non-applicable.")]
    [SerializeField]
    private GameObject CompletionObject;

    private CanvasManager canvasManager;
    private PlayerMovement playerMovement;
    private MouseLook mouseLook;
    private PuzzleManager puzzleManager;
    private InventoryObject CompletionObjectInv;
    public bool isComplete = false;

    protected override void Awake()
    {
        base.Awake();
        canvasManager = FindObjectOfType<CanvasManager>();
        playerMovement = FindObjectOfType<PlayerMovement>();
        mouseLook = FindObjectOfType<MouseLook>();
        puzzleManager = GetComponent<PuzzleManager>();
        PuzzleCamera.enabled = false;
        PuzzleCanvas.enabled = false;
        if (CompletionObject != null)
            CompletionObjectInv = CompletionObject.GetComponent<InventoryObject>();
    }
    private void Update()
    {
        if(Input.GetButtonDown("Cancel"))
        {
            DisablePuzzle();
        }
    }

    public override void InteractWith(int id)
    {
        Debug.Log("Interacted with puzzle");
        base.InteractWith(id);
        if(id != 0)
        {
            puzzleManager.InteractWithPuzzle(id);
        }
        else
        {
            EnablePuzzle();
        }
    }
    public void EnablePuzzle()
    {
        PuzzleCamera.enabled = true;
        PlayerCamera.enabled = false;
        PuzzleCanvas.enabled = true;
        canvasManager.canUse = false;
        mouseLook.enabled = false;
        playerMovement.enabled = false;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
    public void DisablePuzzle()
    {
        PuzzleCamera.enabled = false;
        PlayerCamera.enabled = true;
        PuzzleCanvas.enabled = false;
        canvasManager.canUse = true;
        mouseLook.enabled = true;
        playerMovement.enabled = true;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        if(isComplete)
        {
            this.gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }

    public void GiveItem()
    {
        if(CompletionObject != null)
            CompletionObjectInv.InteractWith(0);
    }
}

