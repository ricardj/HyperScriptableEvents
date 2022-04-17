using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "New Empty Event", menuName = "Hyper Events/New Empty Event")]
public class EmptyEventSO : BaseDescriptionSO
{
    public UnityAction OnEventRaised;

    public void AddListener(UnityAction unityAction)
    {
        OnEventRaised += unityAction;
    }
    public void RemoveListener (UnityAction unityAction)
    {
        OnEventRaised -= unityAction;
    }

    public void RaiseEvent()
    {
        if (OnEventRaised != null)
            OnEventRaised.Invoke();
    }
}

