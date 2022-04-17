using UnityEngine;
using UnityEngine.Events;

public class GenericEventSO<T> : BaseDescriptionSO
{
    public UnityAction<T> OnEventRaised;

    [Header("Debug value")]
    public T debugValue;


    public void AddListener(UnityAction<T> eventListener)
    {
        OnEventRaised += eventListener;
    }

    public void RemoveListener(UnityAction<T> eventListener)
    {
        OnEventRaised -= eventListener;
    }

    public void RaiseEvent(T eventContent)
    {
        if (OnEventRaised != null)
            OnEventRaised.Invoke(eventContent);
    }
}