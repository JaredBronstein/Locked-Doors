using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasManager : MonoBehaviour
{
    [SerializeField]
    private GameObject inventory, journal, hud;

    private void Awake()
    {
        hud.SetActive(true);
        inventory.SetActive(false);
        journal.SetActive(false);
    }

    private void Update()
    {
        if(Input.GetButtonDown("Inventory"))
        {
            hud.SetActive(false);
            inventory.SetActive(true);
            journal.SetActive(false);
        }
        if(Input.GetButtonDown("Journal"))
        {
            hud.SetActive(false);
            inventory.SetActive(false);
            journal.SetActive(true);
        }
    }
}
