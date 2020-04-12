using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WardrobeItemDetect : MonoBehaviour
{
    [SerializeField]
    private GameObject ImportantItem;

    [SerializeField]
    private InteractivePuzzle interactivePuzzle;

    private void Awake()
    {
        ImportantItem.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Trigger")
        {
            ImportantItem.SetActive(true);
            this.gameObject.SetActive(false);
            interactivePuzzle.isComplete = true;
            interactivePuzzle.DisablePuzzle();
        }
    }
}
