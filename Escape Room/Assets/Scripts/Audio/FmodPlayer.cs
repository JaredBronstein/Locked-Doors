using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FmodPlayer : MonoBehaviour
{
    // ckrueger audio

    CharacterController controller;

    private bool isMoving = false;
    private float distance = 1.5f;
    private float Material;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

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
        MaterialCheck();
        MovementCheck();
    }

    // change boolean state to reflect whether or not player is moving
    void MovementCheck()
    {
        if (controller.velocity > 0.01f)
        {
            isMoving = true;
        }
        else
        {
            isMoving = false;
        }
    }

    // use a ray to check the material of colliders beneath player 
    void MaterialCheck()
    {
        RaycastHit hit;
        Debug.DrawRay(transform.position, Vector3.down * distance, Color.blue);

        if (Physics.Raycast(transform.position, Vector3.down, out hit, distance))
        {
            if (hit.collider.tag == "Wood")
            {
                Material = 1f;
            }
            else if (hit.collider.tag == "Carpet")
            {
                Material = 2f;
            }
            else if (hit.collider.tag == "Stone")
            {
                Material = 3f;
            }
            else
            {
                Material = 1f;
            }

        }
    }
    */

    // play footstep sound repeatedly while player is moving
    void PlayFootstep()
    {
        if (isMoving)
        {
            InvokeRepeating(FMODUnity.RuntimeManager.PlayOneShot("Footsteps", gameObject.GetComponent<Transform>().position), 0f, 0.3f);
        }
    }
}