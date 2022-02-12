using UnityEngine;

public class SignalValue<T> : ScriptableObject
{
    public ISignalEvent<T> m_OnUpdateValue;
    public ISignalEvent<T> OnUpdateValue
    {
        get
        {
            if (m_OnUpdateValue == null) m_OnUpdateValue = new SignalEvent<T>();
            return m_OnUpdateValue;
        }
        set { m_OnUpdateValue = value; }
    }

    private T m_Value;
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