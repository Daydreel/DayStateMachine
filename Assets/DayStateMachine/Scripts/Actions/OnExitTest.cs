using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnExitTest : OnExit
{
    public override void Act(DayFSM FSM)
    {
        Debug.Log("OnExitTest");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
