using UnityEngine;
using System;

[Serializable]
public class SignalValue<T> : ScriptableObject, ISignalValue<T>
{
    [HideInInspector] [SerializeField] private ISignalEvent<T> m_OnUpdateValue;
    public ISignalEvent<T> OnUpdateValue
    {
        get
        {
            if (m_OnUpdateValue == null) m_OnUpdateValue = new SignalEvent<T>();
            return m_OnUpdateValue;
        }
        set { m_OnUpdateValue = value; }
    }

    [HideInInspector] [SerializeField] private T m_Value;
    public T Value
    {
        get { return m_Value; }
        set
        {
            m_Value = value;
            OnUpdateValue.Invoke(value);
        }
    }
}