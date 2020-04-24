using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Made by Jonathan Way, Editted by Jared Bronstein
public class BookshelffPuzzle : MonoBehaviour
{
    [SerializeField]
    GameObject[] Books;

    [SerializeField]
    Material book1Mat, book2Mat, book3Mat, book4Mat;

    [SerializeField]
    private InteractivePuzzle interactivePuzzle;

    Books thisBook;
    public bool orderCorrect = false;
    int thisBookNumber, nextBookNumber;

    //Note: Move from Update to at the end of BookSwitch. Small memory save but that way it only checks after something is changed
    void Update()
    {
        BookCheck();
    }

    private void BookCheck()
    {
        for(int i = 0; i < Books.Length; i++)
        {
            thisBook = Books[i].GetComponent<Books>();
            if (thisBook.BookNumber == i + 1)
            {
                orderCorrect = true;
            }
            else
            {
                orderCorrect = false;
                i = Books.Length;
            }   
        }
        if (orderCorrect == true)
        {
            interactivePuzzle.DisablePuzzle();
        }
    }

    private void MatSwitch(int whichOne, int whatColor)
    {
        switch (whatColor)
        {
            case 1:
                Books[whichOne].GetComponent<MeshRenderer>().material = book1Mat;
                break;

            case 2:
                Books[whichOne].GetComponent<MeshRenderer>().material = book2Mat;
                break;

            case 3:
                Books[whichOne].GetComponent<MeshRenderer>().material = book3Mat;
                break;

            case 4:
                Books[whichOne].GetComponent<MeshRenderer>().material = book4Mat;
                break;
        }
    }

    public void BookSwitch(int whichOne)
    {
        thisBook = Books[whichOne - 1].GetComponent<Books>();
        thisBookNumber = thisBook.BookNumber;

        thisBook = Books[whichOne].GetComponent<Books>();
        nextBookNumber = thisBook.BookNumber;
        thisBook.ChangeState(thisBookNumber);
        MatSwitch(whichOne, thisBook.BookNumber);

        thisBook = Books[whichOne - 1].GetComponent<Books>();
        thisBook.ChangeState(nextBookNumber);
        MatSwitch((whichOne - 1), thisBook.BookNumber);
    }
}
