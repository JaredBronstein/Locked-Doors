using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JournalGoal : MonoBehaviour
{
    [Tooltip("Text displaying the goal. If this reference is to delete a goal, ignore")]
    [TextArea(3, 8)]
    [SerializeField]
    private string goalText;

    [Tooltip("ID number for the goal for deletion. Match number with Add and Remove versions to properly connect")]
    [SerializeField]
    private int goalID;

    public string GoalText => goalText;
    public int GoalID => goalID;

    public void AddGoal()
    {
        JournalMenu.Instance.AddGoal(this);
    }
    public void RemoveGoal()
    {
        JournalMenu.Instance.RemoveGoal(this);
    }
}
