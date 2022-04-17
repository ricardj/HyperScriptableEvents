using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class GenericEventSOEditor<T> : Editor
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
        GenericEventSO<T> hyperChannel = (GenericEventSO<T>)target;
        hyperChannel.RaiseEvent(hyperChannel.debugValue);
    }
}
