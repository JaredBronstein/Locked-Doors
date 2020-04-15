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
    private float floorMaterial; // 1f = wood, 2f = carpet, 3f = stone
    private string sceneName;

    Vector3 lastPos;
    Vector3 currentPos;

    void Start()
    {
        // fetch scene name
        sceneName = SceneManager.GetActiveScene().name;

        // instantiate footsteps event
        Footsteps = FMODUnity.RuntimeManager.CreateInstance("event:/Footsteps");

        SetFloorMaterial();

        // fetch player prefab in scene
        player = GameObject.FindGameObjectWithTag("Player");

        isMoving = false;
    }

    void Update()
    {
        // fetch player's current position
        currentPos = player.transform.position;

        // if player is moving, call method that plays step sounds repeatedly
        if (!isMoving && (currentPos.x > lastPos.x || currentPos.x < lastPos.x))
        {
            RepeatFootsteps();
            isMoving = true;
        }

        // if player is standing still, cancel step sounds
        if (currentPos.x == lastPos.x)
        {
            CancelInvoke();
            isMoving = false;
        }

        lastPos = currentPos;
    }

    // repeat footstep sound at set interval
    private void RepeatFootsteps()
    {
        InvokeRepeating("FootstepSound", 0f, 0.4f);
    }

    // plays a single footstep sound
    private void FootstepSound()
    {
        Footsteps.start();
    }

    // determines floor material based on scene name
    private void SetFloorMaterial()
    {
        switch (sceneName)
        {
            case "Bedroom":
                floorMaterial = 2; //carpet
                break;

            case "Foyer":
                floorMaterial = 1; //wood
                break;

            case "Basement":
                floorMaterial = 3; //stone
                break;

            default:
                floorMaterial = 2;
                break;
        }

        // set Material parameter in FMOD event to desired value
        Footsteps.setParameterByName("Material", floorMaterial);
    }
}