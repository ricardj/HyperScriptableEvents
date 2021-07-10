using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "Standard channel", menuName = "HyperChannels / TransformChannel")]
public class HyperTransformChannelSO : HyperBaseChannelSO
{
    public UnityAction<Transform> OnRaiseEvent;

    public void RaiseEvent(Transform value)
    {
        if (OnRaiseEvent != null)
            OnRaiseEvent.Invoke(value);
    }
}
