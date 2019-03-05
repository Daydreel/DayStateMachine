using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class DayFSMEditor : NodeBasedEditor
{
    List<FiniteStateMachine> FSMs;

    [MenuItem("Tool/ Day FSM Editor")]
    private static void OpenWindow()
    {
        DayFSMEditor window = GetWindow<DayFSMEditor>();
        window.titleContent = new GUIContent("Day FSM Editor");
    }
}
