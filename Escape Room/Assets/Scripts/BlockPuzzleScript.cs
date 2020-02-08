using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockPuzzleScript : MonoBehaviour
{
    [SerializeField]
    GameObject[] blockLocations;

    [SerializeField]
    Material Open, Blocked, Key, Hole;

    PuzzleBlock thisBlock;

    // Start is called before the first frame update
    private void Awake()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MovingBlocks9(int thisOne)
    {
        switch (thisOne)
        {
            
            case 1:
                thisBlock = blockLocations[0].GetComponent<PuzzleBlock>();
                #region
                if (thisBlock.isKey == true)
                {
                    thisBlock.ChangeState(4);
                    blockLocations[0].GetComponent<MeshRenderer>().material = Open;

                    thisBlock = blockLocations[1].GetComponent<PuzzleBlock>();
                    if (thisBlock.isOpen == Open)
                    {
                        thisBlock.ChangeState(1);
                        blockLocations[1].GetComponent<MeshRenderer>().material = Key;
                    }
                    thisBlock = blockLocations[3].GetComponent<PuzzleBlock>();
                    if (thisBlock.isOpen == Open)
                    {
                        thisBlock.ChangeState(1);
                        blockLocations[3].GetComponent<MeshRenderer>().material = Key;
                    }
                }
                else if (thisBlock.isHole == true)
                {
                    thisBlock.ChangeState(4);
                    blockLocations[0].GetComponent<MeshRenderer>().material = Open;

                    thisBlock = blockLocations[1].GetComponent<PuzzleBlock>();
                    if (thisBlock.isOpen == Open)
                    {
                        thisBlock.ChangeState(2);
                        blockLocations[1].GetComponent<MeshRenderer>().material = Hole;
                    }
                    thisBlock = blockLocations[3].GetComponent<PuzzleBlock>();
                    if (thisBlock.isOpen == Open)
                    {
                        thisBlock.ChangeState(2);
                        blockLocations[3].GetComponent<MeshRenderer>().material = Hole;
                    }

                }
                else if (thisBlock.isBlocked == true)
                {
                    thisBlock.ChangeState(4);
                    blockLocations[0].GetComponent<MeshRenderer>().material = Open;

                    thisBlock = blockLocations[1].GetComponent<PuzzleBlock>();
                    if (thisBlock.isOpen == Open)
                    {
                        thisBlock.ChangeState(3);
                        blockLocations[1].GetComponent<MeshRenderer>().material = Blocked;
                    }
                    thisBlock = blockLocations[3].GetComponent<PuzzleBlock>();
                    if (thisBlock.isOpen == Open)
                    {
                        thisBlock.ChangeState(3);
                        blockLocations[3].GetComponent<MeshRenderer>().material = Blocked;
                    }
                }
                #endregion
                break;

            case 2:
                thisBlock = blockLocations[1].GetComponent<PuzzleBlock>();
                #region
                if (thisBlock.isKey == true)
                {
                    thisBlock.ChangeState(4);
                    blockLocations[1].GetComponent<MeshRenderer>().material = Open;

                    thisBlock = blockLocations[0].GetComponent<PuzzleBlock>();
                    if (thisBlock.isOpen == Open)
                    {
                        thisBlock.ChangeState(1);
                        blockLocations[0].GetComponent<MeshRenderer>().material = Key;
                    }
                    thisBlock = blockLocations[2].GetComponent<PuzzleBlock>();
                    if (thisBlock.isOpen == Open)
                    {
                        thisBlock.ChangeState(1);
                        blockLocations[2].GetComponent<MeshRenderer>().material = Key;
                    }
                    thisBlock = blockLocations[4].GetComponent<PuzzleBlock>();
                    if (thisBlock.isOpen == Open)
                    {
                        thisBlock.ChangeState(1);
                        blockLocations[4].GetComponent<MeshRenderer>().material = Key;
                    }
                }
                else if (thisBlock.isHole == true)
                {
                    thisBlock.ChangeState(4);
                    blockLocations[1].GetComponent<MeshRenderer>().material = Open;

                    thisBlock = blockLocations[0].GetComponent<PuzzleBlock>();
                    if (thisBlock.isOpen == Open)
                    {
                        thisBlock.ChangeState(2);
                        blockLocations[0].GetComponent<MeshRenderer>().material = Hole;
                    }
                    thisBlock = blockLocations[2].GetComponent<PuzzleBlock>();
                    if (thisBlock.isOpen == Open)
                    {
                        thisBlock.ChangeState(2);
                        blockLocations[2].GetComponent<MeshRenderer>().material = Hole;
                    }
                    thisBlock = blockLocations[4].GetComponent<PuzzleBlock>();
                    if (thisBlock.isOpen == Open)
                    {
                        thisBlock.ChangeState(2);
                        blockLocations[4].GetComponent<MeshRenderer>().material = Hole;
                    }
                }
                else if (thisBlock.isBlocked == true)
                {
                    thisBlock.ChangeState(4);
                    blockLocations[1].GetComponent<MeshRenderer>().material = Open;

                    thisBlock = blockLocations[0].GetComponent<PuzzleBlock>();
                    if (thisBlock.isOpen == Open)
                    {
                        thisBlock.ChangeState(3);
                        blockLocations[0].GetComponent<MeshRenderer>().material = Blocked;
                    }
                    thisBlock = blockLocations[2].GetComponent<PuzzleBlock>();
                    if (thisBlock.isOpen == Open)
                    {
                        thisBlock.ChangeState(3);
                        blockLocations[2].GetComponent<MeshRenderer>().material = Blocked;
                    }
                    thisBlock = blockLocations[4].GetComponent<PuzzleBlock>();
                    if (thisBlock.isOpen == Open)
                    {
                        thisBlock.ChangeState(3);
                        blockLocations[4].GetComponent<MeshRenderer>().material = Blocked;
                    }
                }
                #endregion
                break;

            case 3:
                thisBlock = blockLocations[2].GetComponent<PuzzleBlock>();
                #region
                if (thisBlock.isKey == true)
                {
                    thisBlock.ChangeState(4);
                    blockLocations[2].GetComponent<MeshRenderer>().material = Open;

                    thisBlock = blockLocations[1].GetComponent<PuzzleBlock>();
                    if (thisBlock.isOpen == Open)
                    {
                        thisBlock.ChangeState(1);
                        blockLocations[1].GetComponent<MeshRenderer>().material = Key;
                    }
                    thisBlock = blockLocations[5].GetComponent<PuzzleBlock>();
                    if (thisBlock.isOpen == Open)
                    {
                        thisBlock.ChangeState(1);
                        blockLocations[5].GetComponent<MeshRenderer>().material = Key;
                    }
                }
                else if (thisBlock.isHole == true)
                {
                    thisBlock.ChangeState(4);
                    blockLocations[2].GetComponent<MeshRenderer>().material = Open;

                    thisBlock = blockLocations[1].GetComponent<PuzzleBlock>();
                    if (thisBlock.isOpen == Open)
                    {
                        thisBlock.ChangeState(2);
                        blockLocations[1].GetComponent<MeshRenderer>().material = Hole;
                    }
                    thisBlock = blockLocations[5].GetComponent<PuzzleBlock>();
                    if (thisBlock.isOpen == Open)
                    {
                        thisBlock.ChangeState(2);
                        blockLocations[5].GetComponent<MeshRenderer>().material = Hole;
                    }

                }
                else if (thisBlock.isBlocked == true)
                {
                    thisBlock.ChangeState(4);
                    blockLocations[2].GetComponent<MeshRenderer>().material = Open;

                    thisBlock = blockLocations[1].GetComponent<PuzzleBlock>();
                    if (thisBlock.isOpen == Open)
                    {
                        thisBlock.ChangeState(3);
                        blockLocations[1].GetComponent<MeshRenderer>().material = Blocked;
                    }
                    thisBlock = blockLocations[5].GetComponent<PuzzleBlock>();
                    if (thisBlock.isOpen == Open)
                    {
                        thisBlock.ChangeState(3);
                        blockLocations[5].GetComponent<MeshRenderer>().material = Blocked;
                    }
                }
                #endregion
                break;

            case 4:
                thisBlock = blockLocations[3].GetComponent<PuzzleBlock>();
                #region
                if (thisBlock.isKey == true)
                {
                    thisBlock.ChangeState(4);
                    blockLocations[3].GetComponent<MeshRenderer>().material = Open;

                    thisBlock = blockLocations[0].GetComponent<PuzzleBlock>();
                    if (thisBlock.isOpen == Open)
                    {
                        thisBlock.ChangeState(1);
                        blockLocations[0].GetComponent<MeshRenderer>().material = Key;
                    }
                    thisBlock = blockLocations[4].GetComponent<PuzzleBlock>();
                    if (thisBlock.isOpen == Open)
                    {
                        thisBlock.ChangeState(1);
                        blockLocations[4].GetComponent<MeshRenderer>().material = Key;
                    }
                    thisBlock = blockLocations[6].GetComponent<PuzzleBlock>();
                    if (thisBlock.isOpen == Open)
                    {
                        thisBlock.ChangeState(1);
                        blockLocations[6].GetComponent<MeshRenderer>().material = Key;
                    }
                }
                else if (thisBlock.isHole == true)
                {
                    thisBlock.ChangeState(4);
                    blockLocations[3].GetComponent<MeshRenderer>().material = Open;

                    thisBlock = blockLocations[0].GetComponent<PuzzleBlock>();
                    if (thisBlock.isOpen == Open)
                    {
                        thisBlock.ChangeState(2);
                        blockLocations[0].GetComponent<MeshRenderer>().material = Hole;
                    }
                    thisBlock = blockLocations[4].GetComponent<PuzzleBlock>();
                    if (thisBlock.isOpen == Open)
                    {
                        thisBlock.ChangeState(2);
                        blockLocations[4].GetComponent<MeshRenderer>().material = Hole;
                    }
                    thisBlock = blockLocations[6].GetComponent<PuzzleBlock>();
                    if (thisBlock.isOpen == Open)
                    {
                        thisBlock.ChangeState(2);
                        blockLocations[6].GetComponent<MeshRenderer>().material = Hole;
                    }
                }
                else if (thisBlock.isBlocked == true)
                {
                    thisBlock.ChangeState(4);
                    blockLocations[3].GetComponent<MeshRenderer>().material = Open;

                    thisBlock = blockLocations[0].GetComponent<PuzzleBlock>();
                    if (thisBlock.isOpen == Open)
                    {
                        thisBlock.ChangeState(3);
                        blockLocations[0].GetComponent<MeshRenderer>().material = Blocked;
                    }
                    thisBlock = blockLocations[4].GetComponent<PuzzleBlock>();
                    if (thisBlock.isOpen == Open)
                    {
                        thisBlock.ChangeState(3);
                        blockLocations[4].GetComponent<MeshRenderer>().material = Blocked;
                    }
                    thisBlock = blockLocations[6].GetComponent<PuzzleBlock>();
                    if (thisBlock.isOpen == Open)
                    {
                        thisBlock.ChangeState(3);
                        blockLocations[6].GetComponent<MeshRenderer>().material = Blocked;
                    }
                }
                #endregion
                break;

            case 5:
                thisBlock = blockLocations[4].GetComponent<PuzzleBlock>();

                #region
                if (thisBlock.isKey == true)
                {
                    thisBlock.ChangeState(4);
                    blockLocations[4].GetComponent<MeshRenderer>().material = Open;

                    thisBlock = blockLocations[3].GetComponent<PuzzleBlock>();
                    if (thisBlock.isOpen == true)
                    {
                        thisBlock.ChangeState(1);
                        blockLocations[3].GetComponent<MeshRenderer>().material = Key;
                    }

                    thisBlock = blockLocations[1].GetComponent<PuzzleBlock>();
                    if (thisBlock.isOpen == true)
                    {
                        thisBlock.ChangeState(1);
                        blockLocations[1].GetComponent<MeshRenderer>().material = Key;
                    }

                    thisBlock = blockLocations[5].GetComponent<PuzzleBlock>();
                    if (thisBlock.isOpen == Open)
                    {
                        thisBlock.ChangeState(1);
                        blockLocations[5].GetComponent<MeshRenderer>().material = Key;
                    }

                    thisBlock = blockLocations[7].GetComponent<PuzzleBlock>();
                    if (thisBlock.isOpen == Open)
                    {
                        thisBlock.ChangeState(1);
                        blockLocations[7].GetComponent<MeshRenderer>().material = Key;
                    }
                }
                else if(thisBlock.isHole == true)
                {
                    thisBlock.ChangeState(4);
                    blockLocations[4].GetComponent<MeshRenderer>().material = Open;

                    thisBlock = blockLocations[3].GetComponent<PuzzleBlock>();
                    if (thisBlock.isOpen == Open)
                    {
                        thisBlock.ChangeState(2);
                        blockLocations[3].GetComponent<MeshRenderer>().material = Hole;
                    }

                    thisBlock = blockLocations[1].GetComponent<PuzzleBlock>();
                    if (thisBlock.isOpen == Open)
                    {
                        thisBlock.ChangeState(2);
                        blockLocations[1].GetComponent<MeshRenderer>().material = Hole;
                    }

                    thisBlock = blockLocations[5].GetComponent<PuzzleBlock>();
                    if (thisBlock.isOpen == Open)
                    {
                        thisBlock.ChangeState(2);
                        blockLocations[5].GetComponent<MeshRenderer>().material = Hole;
                    }
                    thisBlock = blockLocations[7].GetComponent<PuzzleBlock>();
                    if (thisBlock.isOpen == Open)
                    {
                        thisBlock.ChangeState(2);
                        blockLocations[7].GetComponent<MeshRenderer>().material = Hole;
                    }
                }
                else if(thisBlock.isBlocked == true)
                {
                    thisBlock.ChangeState(4);
                    blockLocations[4].GetComponent<MeshRenderer>().material = Open;

                    thisBlock = blockLocations[3].GetComponent<PuzzleBlock>();
                    if (thisBlock.isOpen == Open)
                    {
                        thisBlock.ChangeState(3);
                        blockLocations[3].GetComponent<MeshRenderer>().material = Blocked;
                    }

                    thisBlock = blockLocations[1].GetComponent<PuzzleBlock>();
                    if (thisBlock.isOpen == Open)
                    {
                        thisBlock.ChangeState(3);
                        blockLocations[1].GetComponent<MeshRenderer>().material = Blocked;
                    }

                    thisBlock = blockLocations[5].GetComponent<PuzzleBlock>();
                    if (thisBlock.isOpen == Open)
                    {
                        thisBlock.ChangeState(3);
                        blockLocations[5].GetComponent<MeshRenderer>().material = Blocked;
                    }

                    thisBlock = blockLocations[7].GetComponent<PuzzleBlock>();
                    if (thisBlock.isOpen == Open)
                    {
                        thisBlock.ChangeState(3);
                        blockLocations[7].GetComponent<MeshRenderer>().material = Blocked;
                    }
                }
                #endregion
                break;

            case 6:
                thisBlock = blockLocations[5].GetComponent<PuzzleBlock>();
                #region
                if (thisBlock.isKey == true)
                {
                    thisBlock.ChangeState(4);
                    blockLocations[5].GetComponent<MeshRenderer>().material = Open;

                    thisBlock = blockLocations[2].GetComponent<PuzzleBlock>();
                    if (thisBlock.isOpen == Open)
                    {
                        thisBlock.ChangeState(1);
                        blockLocations[2].GetComponent<MeshRenderer>().material = Key;
                    }

                    thisBlock = blockLocations[4].GetComponent<PuzzleBlock>();
                    if (thisBlock.isOpen == Open)
                    {
                        thisBlock.ChangeState(1);
                        blockLocations[4].GetComponent<MeshRenderer>().material = Key;
                    }

                    thisBlock = blockLocations[8].GetComponent<PuzzleBlock>();
                    if (thisBlock.isOpen == Open)
                    {
                        thisBlock.ChangeState(1);
                        blockLocations[8].GetComponent<MeshRenderer>().material = Key;
                    }

                }
                else if (thisBlock.isHole == true)
                {
                    thisBlock.ChangeState(4);
                    blockLocations[5].GetComponent<MeshRenderer>().material = Open;

                    thisBlock = blockLocations[2].GetComponent<PuzzleBlock>();
                    if (thisBlock.isOpen == Open)
                    {
                        thisBlock.ChangeState(2);
                        blockLocations[2].GetComponent<MeshRenderer>().material = Hole;
                    }

                    thisBlock = blockLocations[4].GetComponent<PuzzleBlock>();
                    if (thisBlock.isOpen == Open)
                    {
                        thisBlock.ChangeState(2);
                        blockLocations[4].GetComponent<MeshRenderer>().material = Hole;
                    }

                    thisBlock = blockLocations[8].GetComponent<PuzzleBlock>();
                    if (thisBlock.isOpen == Open)
                    {
                        thisBlock.ChangeState(2);
                        blockLocations[8].GetComponent<MeshRenderer>().material = Hole;
                    }

                }
                else if (thisBlock.isBlocked == true)
                {
                    thisBlock.ChangeState(4);
                    blockLocations[5].GetComponent<MeshRenderer>().material = Open;

                    thisBlock = blockLocations[2].GetComponent<PuzzleBlock>();
                    if (thisBlock.isOpen == Open)
                    {
                        thisBlock.ChangeState(3);
                        blockLocations[2].GetComponent<MeshRenderer>().material = Blocked;
                    }

                    thisBlock = blockLocations[4].GetComponent<PuzzleBlock>();
                    if (thisBlock.isOpen == Open)
                    {
                        thisBlock.ChangeState(3);
                        blockLocations[4].GetComponent<MeshRenderer>().material = Blocked;
                    }

                    thisBlock = blockLocations[8].GetComponent<PuzzleBlock>();
                    if (thisBlock.isOpen == Open)
                    {
                        thisBlock.ChangeState(3);
                        blockLocations[8].GetComponent<MeshRenderer>().material = Blocked;
                    }
                }
                #endregion
                break;

            case 7:
                thisBlock = blockLocations[6].GetComponent<PuzzleBlock>();
                #region
                if (thisBlock.isKey == true)
                {
                    thisBlock.ChangeState(4);
                    blockLocations[6].GetComponent<MeshRenderer>().material = Open;

                    thisBlock = blockLocations[3].GetComponent<PuzzleBlock>();
                    if (thisBlock.isOpen == Open)
                    {
                        thisBlock.ChangeState(1);
                        blockLocations[3].GetComponent<MeshRenderer>().material = Key;
                    }

                    thisBlock = blockLocations[7].GetComponent<PuzzleBlock>();
                    if (thisBlock.isOpen == Open)
                    {
                        thisBlock.ChangeState(1);
                        blockLocations[7].GetComponent<MeshRenderer>().material = Key;
                    }

                }
                else if (thisBlock.isHole == true)
                {
                    thisBlock.ChangeState(4);
                    blockLocations[6].GetComponent<MeshRenderer>().material = Open;

                    thisBlock = blockLocations[3].GetComponent<PuzzleBlock>();
                    if (thisBlock.isOpen == Open)
                    {
                        thisBlock.ChangeState(2);
                        blockLocations[3].GetComponent<MeshRenderer>().material = Hole;
                    }

                    thisBlock = blockLocations[7].GetComponent<PuzzleBlock>();
                    if (thisBlock.isOpen == Open)
                    {
                        thisBlock.ChangeState(2);
                        blockLocations[7].GetComponent<MeshRenderer>().material = Hole;
                    }


                }
                else if (thisBlock.isBlocked == true)
                {
                    thisBlock.ChangeState(4);
                    blockLocations[6].GetComponent<MeshRenderer>().material = Open;

                    thisBlock = blockLocations[3].GetComponent<PuzzleBlock>();
                    if (thisBlock.isOpen == Open)
                    {
                        thisBlock.ChangeState(3);
                        blockLocations[3].GetComponent<MeshRenderer>().material = Blocked;
                    }

                    thisBlock = blockLocations[7].GetComponent<PuzzleBlock>();
                    if (thisBlock.isOpen == Open)
                    {
                        thisBlock.ChangeState(3);
                        blockLocations[7].GetComponent<MeshRenderer>().material = Blocked;
                    }

                }
                #endregion
                break;

            case 8:
                thisBlock = blockLocations[7].GetComponent<PuzzleBlock>();
                #region
                if (thisBlock.isKey == true)
                {
                    thisBlock.ChangeState(4);
                    blockLocations[7].GetComponent<MeshRenderer>().material = Open;

                    thisBlock = blockLocations[6].GetComponent<PuzzleBlock>();
                    if (thisBlock.isOpen == Open)
                    {
                        thisBlock.ChangeState(1);
                        blockLocations[6].GetComponent<MeshRenderer>().material = Key;
                    }

                    thisBlock = blockLocations[4].GetComponent<PuzzleBlock>();
                    if (thisBlock.isOpen == Open)
                    {
                        thisBlock.ChangeState(1);
                        blockLocations[4].GetComponent<MeshRenderer>().material = Key;
                    }

                    thisBlock = blockLocations[8].GetComponent<PuzzleBlock>();
                    if (thisBlock.isOpen == Open)
                    {
                        thisBlock.ChangeState(1);
                        blockLocations[8].GetComponent<MeshRenderer>().material = Key;
                    }

                }
                else if (thisBlock.isHole == true)
                {
                    thisBlock.ChangeState(4);
                    blockLocations[7].GetComponent<MeshRenderer>().material = Open;

                    thisBlock = blockLocations[6].GetComponent<PuzzleBlock>();
                    if (thisBlock.isOpen == Open)
                    {
                        thisBlock.ChangeState(2);
                        blockLocations[6].GetComponent<MeshRenderer>().material = Hole;
                    }

                    thisBlock = blockLocations[4].GetComponent<PuzzleBlock>();
                    if (thisBlock.isOpen == Open)
                    {
                        thisBlock.ChangeState(2);
                        blockLocations[4].GetComponent<MeshRenderer>().material = Hole;
                    }

                    thisBlock = blockLocations[8].GetComponent<PuzzleBlock>();
                    if (thisBlock.isOpen == Open)
                    {
                        thisBlock.ChangeState(2);
                        blockLocations[8].GetComponent<MeshRenderer>().material = Hole;
                    }

                }
                else if (thisBlock.isBlocked == true)
                {
                    thisBlock.ChangeState(4);
                    blockLocations[7].GetComponent<MeshRenderer>().material = Open;

                    thisBlock = blockLocations[6].GetComponent<PuzzleBlock>();
                    if (thisBlock.isOpen == Open)
                    {
                        thisBlock.ChangeState(3);
                        blockLocations[6].GetComponent<MeshRenderer>().material = Blocked;
                    }

                    thisBlock = blockLocations[4].GetComponent<PuzzleBlock>();
                    if (thisBlock.isOpen == Open)
                    {
                        thisBlock.ChangeState(3);
                        blockLocations[4].GetComponent<MeshRenderer>().material = Blocked;
                    }

                    thisBlock = blockLocations[8].GetComponent<PuzzleBlock>();
                    if (thisBlock.isOpen == Open)
                    {
                        thisBlock.ChangeState(3);
                        blockLocations[8].GetComponent<MeshRenderer>().material = Blocked;
                    }
                }
                #endregion
                break;

            case 9:
                thisBlock = blockLocations[8].GetComponent<PuzzleBlock>();
                #region
                if (thisBlock.isKey == true)
                {
                    thisBlock.ChangeState(4);
                    blockLocations[8].GetComponent<MeshRenderer>().material = Open;

                    thisBlock = blockLocations[5].GetComponent<PuzzleBlock>();
                    if (thisBlock.isOpen == Open)
                    {
                        thisBlock.ChangeState(1);
                        blockLocations[5].GetComponent<MeshRenderer>().material = Key;
                    }

                    thisBlock = blockLocations[7].GetComponent<PuzzleBlock>();
                    if (thisBlock.isOpen == Open)
                    {
                        thisBlock.ChangeState(1);
                        blockLocations[7].GetComponent<MeshRenderer>().material = Key;
                    }

                }
                else if (thisBlock.isHole == true)
                {
                    thisBlock.ChangeState(4);
                    blockLocations[8].GetComponent<MeshRenderer>().material = Open;

                    thisBlock = blockLocations[5].GetComponent<PuzzleBlock>();
                    if (thisBlock.isOpen == Open)
                    {
                        thisBlock.ChangeState(2);
                        blockLocations[5].GetComponent<MeshRenderer>().material = Hole;
                    }

                    thisBlock = blockLocations[7].GetComponent<PuzzleBlock>();
                    if (thisBlock.isOpen == Open)
                    {
                        thisBlock.ChangeState(2);
                        blockLocations[7].GetComponent<MeshRenderer>().material = Hole;
                    }


                }
                else if (thisBlock.isBlocked == true)
                {
                    thisBlock.ChangeState(4);
                    blockLocations[8].GetComponent<MeshRenderer>().material = Open;

                    thisBlock = blockLocations[5].GetComponent<PuzzleBlock>();
                    if (thisBlock.isOpen == Open)
                    {
                        thisBlock.ChangeState(3);
                        blockLocations[5].GetComponent<MeshRenderer>().material = Blocked;
                    }

                    thisBlock = blockLocations[7].GetComponent<PuzzleBlock>();
                    if (thisBlock.isOpen == Open)
                    {
                        thisBlock.ChangeState(3);
                        blockLocations[7].GetComponent<MeshRenderer>().material = Blocked;
                    }
                }
                #endregion
                break;

        }
        
    }

}
