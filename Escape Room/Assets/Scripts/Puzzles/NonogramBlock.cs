using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonogramBlock : MonoBehaviour
{
    [SerializeField]
    public bool active;

    private void Start()
    {
        active = false;
    }

    public void ChangeState()
    {
        if(active == false)
            active = true;
        else
            active = false;
    }
}
