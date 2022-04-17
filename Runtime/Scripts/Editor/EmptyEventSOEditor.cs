using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(EmptyEventSO))]
public class EmptyEventSOEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        if (GUILayout.Button("Debug Event"))
        {
            RaiseEvent();
        }
    }

    public virtual void RaiseEvent()
    {
        EmptyEventSO hyperChannel = (EmptyEventSO)target;
        hyperChannel.RaiseEvent();
    }
}
