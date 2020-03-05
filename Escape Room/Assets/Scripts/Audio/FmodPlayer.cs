using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FmodPlayer : MonoBehaviour
{
    private float distance = 0.05f;
    private float Material;

    void FixedUpdate()
    {
       // MaterialCheck();
        Debug.DrawRay(transform.position, Vector3.down * distance, Color.blue);
    }

   /* void MaterialCheck()
    {
        RaycastHit hit;

        //this doesnt seem to want to compile right
        hit = Physics.Raycast(transform.position, Vector3.down, distance);

        if (hit.collider)
        {
            if (hit.collider.tag == "Wood")
                Material = 1f;
            else if (hit.collider.tag == "Carpet")
                Material = 2f;
            else if (hit.collider.tag == "Stone")
                Material = 3f;
            else
                Material = 1f;
        }
    }
    */

    void PlayFootstepsEvent(string path)
    {
        FMOD.Studio.EventInstance Footsteps = FMODUnity.RuntimeManager.CreateInstance(path);
        Footsteps.setParameterByName("Material", Material);
        Footsteps.start();
        Footsteps.release();
    }
}