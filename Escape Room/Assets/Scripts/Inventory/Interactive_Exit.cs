using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Interactive_Exit : InteractiveObject
{
    public override void InteractWith(int id)
    {
        base.InteractWith(id);
        SceneManager.LoadScene("Ending");
    }
}
