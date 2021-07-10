using UnityEngine;
using UnityEngine.Events;


[CreateAssetMenu(fileName = "Standard channel", menuName = "HyperChannels / Bool Channel")]
public class HyperBoolChannelSO : HyperBaseChannelSO
{
    public UnityAction<bool> OnEventRaised;

    public void RaiseEvent(bool condition)
    {
        if (OnEventRaised != null)
            OnEventRaised.Invoke(condition);
    }
}