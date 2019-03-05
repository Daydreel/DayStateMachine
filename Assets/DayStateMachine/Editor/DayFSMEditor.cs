using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class DayFSMEditor : EditorWindow
{
    //Load all the DayFSM for editor
    List<DayFSM> FSMs;

    [MenuItem("Tool/ Day FSM Editor")]
    private static void OpenWindow()
    {
        DayFSMEditor window = GetWindow<DayFSMEditor>("Day FSM Editor");
    }

    private void OnGUI()
    {
        
    }

    #region Save/Load

    #endregion
}
