using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JournalGoal : MonoBehaviour
{
    [TextArea(3, 8)]
    [SerializeField]
    private string goalText;

    [SerializeField]
    private int id;

    public string GoalText => goalText;
    public int ID => id;

    public void AddGoal()
    {
        JournalMenu.Instance.AddGoal(this);
    }
    public void RemoveGoal()
    {
        JournalMenu.Instance.RemoveGoal(this);
    }
}
