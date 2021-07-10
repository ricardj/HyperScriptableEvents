using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "Standard channel", menuName = "HyperChannels / Standard Channel")]
public class HyperChannelSO : HyperBaseChannelSO
{
    public UnityAction OnEventRaised;

    public void RaiseEvent()
    {
        if (OnEventRaised != null)
            OnEventRaised.Invoke();
    }
}

