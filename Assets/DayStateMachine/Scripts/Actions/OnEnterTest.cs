using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnEnterTest : OnEnter
{
    public override void Act(DayFSM FSM)
    {
        Debug.Log("OnEnterTest");
    }
}
