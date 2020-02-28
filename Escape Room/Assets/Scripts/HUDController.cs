using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDController : MonoBehaviour
{
    [SerializeField]
    private Image image;

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
    }
}
