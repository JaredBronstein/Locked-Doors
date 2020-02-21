using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalTrigger : MonoBehaviour
{
    private BoxCollider collider;
    private JournalGoal goal;

    private void Awake()
    {
        collider = GetComponent<BoxCollider>();
        goal = GetComponent<JournalGoal>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            goal.RemoveGoal();
        }
    }
}
