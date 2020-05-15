using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : InteractiveObject
{
    [SerializeField]
    private Light[] lights;

    [SerializeField]
    private GameObject regshroom, glowshroom;

    private float[] lightIntensities;

    private bool isOn = true;

    private void Awake()
    {
        lightIntensities = new float[lights.Length];
        for(int i=0; i < lightIntensities.Length; i++)
        {
            lightIntensities[i] = lights[i].intensity;
        }
        regshroom.SetActive(true);
        glowshroom.SetActive(false);
    }

    public override void InteractWith(int id)
    {
        base.InteractWith(id);
        for(int i=0; i < lights.Length; i++)
        {
            if (lights[i].intensity > 0)
            {
                lights[i].intensity = 0;
            }
            else
            {
                lights[i].intensity = lightIntensities[i];
            }

        }
        if(isOn)
        {
            isOn = false;
            glowshroom.SetActive(true);
            regshroom.SetActive(false);
        }
        else
        {
            isOn = true;
            glowshroom.SetActive(false);
            regshroom.SetActive(true);
        }
    }


}
