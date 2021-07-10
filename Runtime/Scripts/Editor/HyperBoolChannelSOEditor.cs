using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(HyperBoolChannelSO))]
public class HyperBoolChannelSOEditor : HyperChannelSOEditor
{
    bool defaultValue = false;
    public override void OnInspectorGUI()
    {

        defaultValue = GUILayout.Toggle(defaultValue, "Default value");
        base.OnInspectorGUI();
    }
    public override void RaiseEvent()
    {
        HyperBoolChannelSO hyperBoolChannelSO = (HyperBoolChannelSO)target;
        hyperBoolChannelSO.RaiseEvent(defaultValue);
    }
}
