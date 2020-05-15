using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoonogramPuzzle : MonoBehaviour
{
    [SerializeField]
    Material on, off;

    [SerializeField]
    GameObject[] Blocks;

    [SerializeField]
    private InteractivePuzzle InteractivePuzzle;

    [SerializeField]
    private MeshCollider Door;

    //tooltip this to literally write (size is 25 same as above)
    //  a b c d e
    //a 1 2 3 4 5
    //b 6 7 8 9 10
    //c 11 12 13 14 15
    //d 16 17 18 19 20
    //e 21 22 23 24 25
    [SerializeField]
    bool[] Code;

    NonogramBlock thisBlock;
    public bool finished = false;

    private void Awake()
    {
        Door.enabled = false;
    }

    void Update()
    {
        MaterialUpdate();
        CheckPuzzle();
    }

    void CheckPuzzle()
    {
        for (int i = 0; i < Blocks.Length; i++)
        {
            thisBlock = Blocks[i].GetComponent<NonogramBlock>();
            if (thisBlock.active == Code[i])
                finished = true;
            else
            {
                finished = false;
                i = Blocks.Length;
            }     
        }
        if(finished)
        {
            InteractivePuzzle.isComplete = true;
            InteractivePuzzle.DisablePuzzle();
            Door.enabled = true;
            this.gameObject.SetActive(false);
        }
    }

    void MaterialUpdate()
    {
        for(int i = 0; i < Blocks.Length; i++)
        {
            thisBlock = Blocks[i].GetComponent<NonogramBlock>();
            if (thisBlock.active == true)
                Blocks[i].GetComponent<MeshRenderer>().material = on;
            else
                Blocks[i].GetComponent<MeshRenderer>().material = off;       
        }
    }
}
