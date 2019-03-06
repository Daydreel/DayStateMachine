using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "TW/Actions/Idle")]
public class Idle : Action
{
    public override void Act(DayFSM fsm)
    {
        ActIdle(fsm);
    }

    private void ActIdle(DayFSM fsm)
    {

    }
}
