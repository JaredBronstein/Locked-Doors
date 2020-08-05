using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDController : MonoBehaviour
{
    [SerializeField]
    private Image image;

    [SerializeField]
    private Text ObservationText;

    /// <summary>
    /// Used to swap the cursor with the item the player has selected
    /// </summary>
    /// <param name="itemImage">The sprite of the item the player selected</param>
    public void ImageSwap(Sprite itemImage)
    {
        image.enabled = true;
        image.sprite = itemImage;
    }
    public void ResetImage()
    {
        image.enabled = false;
    }
    private void Awake()
    {
        ResetImage();
        ObservationText.text = "";
    }
    public void ChangeObservation(string Observation)
    {
        ObservationText.text = Observation;
        StartCoroutine("ResetObservation");
    }

    private IEnumerator ResetObservation()
    {
        yield return new WaitForSeconds(5);
        ObservationText.text = "";
    }
}
