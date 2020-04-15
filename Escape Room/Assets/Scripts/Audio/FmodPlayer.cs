using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FmodPlayer : MonoBehaviour
{
    // ckrueger audio

    FMOD.Studio.EventInstance Footsteps;

    public GameObject player;

    private bool isMoving;
    private int floorMaterial; // 1f = wood, 2f = carpet, 3f = stone
    private string sceneName;

    Vector3 lastPos;
    Vector3 currentPos;

    void Start()
    {
        sceneName = SceneManager.GetActiveScene().name;

        Footsteps = FMODUnity.RuntimeManager.CreateInstance("event:/Footsteps");

        SetFloorMaterial();

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

    // determines footstep sound based on scene name
    private void SetFloorMaterial()
    {
        switch (sceneName)
        {
            case "Bedroom":
                floorMaterial = 2;
                //Debug.Log("Material Set: Bedroom");
                break;

            case "Foyer":
                floorMaterial = 1;
                //Debug.Log("Material Set: Foyer");
                break;

            case "Basement":
                floorMaterial = 3;
                //Debug.Log("Material Set: Basement");
                break;

            default:
                floorMaterial = 2;
                //Debug.Log("Material Set: Default");
                break;
        }

        Footsteps.setParameterByName("Material", floorMaterial);
        Debug.Log("Material Parameter Set");
    }
}