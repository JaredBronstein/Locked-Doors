using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FmodPlayer : MonoBehaviour
{
    // ckrueger audio

    public GameObject player;

    private bool isMoving;

    Vector3 lastPos;
    Vector3 currentPos;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        isMoving = false;
    }

    void Update()
    {
        currentPos = player.transform.position;

        if (!isMoving && (currentPos.x > lastPos.x || currentPos.x < lastPos.x))
        {
            StartFootsteps();
            isMoving = true;
        }
        if (currentPos.x == lastPos.x)
        {
            CancelInvoke();
            isMoving = false;
        }

        lastPos = currentPos;
    }

    // play footsteps
    private void StartFootsteps()
    {
        InvokeRepeating("FootstepSound", 0f, 0.4f);
    }

    // call footstep sound from FMOD
    private void FootstepSound()
    {
        FMODUnity.RuntimeManager.PlayOneShot("event:/Footsteps", gameObject.GetComponent<Transform>().position);
    }
}