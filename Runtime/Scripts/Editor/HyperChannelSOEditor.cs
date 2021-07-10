using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(HyperChannelSO))]
public class HyperChannelSOEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        if (GUILayout.Button("Raise"))
        {
            RaiseEvent();
        }
    }

    public virtual void RaiseEvent()
    {
        HyperChannelSO hyperChannel = (HyperChannelSO)target;
        hyperChannel.RaiseEvent();
    }

}
