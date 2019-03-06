using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "TW/Actions/ActionEvent")]
public class ActionEvent : Action
{
    public UnityEvent Event;

    public override void Act(DayFSM fsm)
    {
        Event.Invoke();
    }
}
