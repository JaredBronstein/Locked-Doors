using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalText : MonoBehaviour
{
    [Tooltip("The goal's text")]
    [SerializeField]
    private Text Goal;

    [Tooltip("The goal's ID number for quick reference")]
    [SerializeField]
    private int GoalID;

    private JournalGoal associatedGoal;

    public JournalGoal AssociatedGoal
    {
        get { return associatedGoal; }
        set
        {
            associatedGoal = value;
            Goal.text = associatedGoal.GoalText;
            GoalID = associatedGoal.GoalID;
        }
    }
}
