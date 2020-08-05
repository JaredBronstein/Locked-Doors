using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Detects when the player presses the Interact button while looking at an IInteractive
/// and then calls that IInteractive's InteractWith method
/// </summary>
public class InteractWithLookedAt : MonoBehaviour
{
    private IInteractive lookedAtInteractive;
    private InteractiveObject lookedAtInteractiveObject;
    private IDTracker idTracker;
    private HUDController HUDcontroller;

    private void Awake()
    {
        idTracker = GetComponent<IDTracker>();
        HUDcontroller = FindObjectOfType<HUDController>();
    }

    void Update()
    {
        //Checks 3 things, if the player presses the interact button, there is something to interact with, and if the IDs match.
        //Consider revising to account for multiple possibilities, it'll make more if statements but it is helpful
        //IE To reset player ID, have it happen if the player presses the interact button and nothing else
        if (Input.GetButtonDown("Interact"))
        {
            if(lookedAtInteractive != null && idTracker.CanInteract(lookedAtInteractive.ID()))
            {
                lookedAtInteractive.InteractWith(idTracker.GetID());
            }
            idTracker.ResetID();
            HUDcontroller.ResetImage();
        }
        if (Input.GetButtonDown("Observe") && lookedAtInteractive != null)
        {
            HUDcontroller.ChangeObservation(lookedAtInteractive.ObservationText);
        }
        if (Input.GetButtonDown("Fire2"))
        {
            idTracker.ResetID();
            HUDcontroller.ResetImage();
        }
    }

    /// <summary>
    /// Event handler for DetectLookedAtInteractive.LookedAtInteractiveChanged
    /// </summary>
    /// <param name="newLookedAtInteractive">Reference to the new IInteractive the player was looking at.</param>
    private void OnLookedAtInteractiveChanged(IInteractive newLookedAtInteractive)
    {
        lookedAtInteractive = newLookedAtInteractive;
    }

    #region Event Subscription / Unsubscription
    private void OnEnable()
    {
        DetectLookedAtInteractive.LookedAtInteractiveChanged += OnLookedAtInteractiveChanged;
    }
    private void OnDisable()
    {
        DetectLookedAtInteractive.LookedAtInteractiveChanged -= OnLookedAtInteractiveChanged;
    }
    #endregion
}
