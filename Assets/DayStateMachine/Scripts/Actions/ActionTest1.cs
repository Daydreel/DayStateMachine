using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionTest1 : Action
{
    public override void Act(DayFSM FSM)
    {
        Debug.Log("Test 1");
    }
}
