using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class DayFSMEditor : EditorWindow
{
    //Load all the DayFSM for editor
    List<DayFSM> FSMs;
    List<string> someTitles;

    [MenuItem("Tool/ Day FSM Editor")]
    private static void OpenWindow()
    {
        DayFSMEditor window = GetWindow<DayFSMEditor>("Day FSM Editor");
    }

    private void OnGUI()
    {
        if (someTitles != null)
        {
            foreach (string title in someTitles)
            {
                GUILayout.Label(title, EditorStyles.boldLabel);
            }
        }
        else
        {
            GUILayout.Label("No Titles", EditorStyles.boldLabel);
        }
    }

    #region Save/Load
    #endregion
}
