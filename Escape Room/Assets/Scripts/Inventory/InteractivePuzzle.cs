using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractivePuzzle : InteractiveObject
{
    [SerializeField]
    private Canvas PuzzleCanvas;
    [SerializeField]
    private Camera PuzzleCamera, PlayerCamera;

    private CanvasManager canvasManager;
    private PlayerMovement playerMovement;
    private MouseLook mouseLook;

    protected override void Awake()
    {
        base.Awake();
        canvasManager = FindObjectOfType<CanvasManager>();
        playerMovement = FindObjectOfType<PlayerMovement>();
        mouseLook = FindObjectOfType<MouseLook>();
        PuzzleCamera.enabled = false;
        PuzzleCanvas.enabled = false;
    }
    private void Update()
    {
        if(Input.GetButtonDown("Cancel"))
        {
            DisablePuzzle();
        }
    }

    public override void InteractWith()
    {
        Debug.Log("Interacted with puzzle");
        base.InteractWith();
        EnablePuzzle();
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
    }
}

