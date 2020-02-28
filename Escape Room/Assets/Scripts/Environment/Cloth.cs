using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Made by Eric Lovelock

public class Cloth : MonoBehaviour
{
    void Update()
    {
        Physics.IgnoreLayerCollision(0, 9);
    }
}
