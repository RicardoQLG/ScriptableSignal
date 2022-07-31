using UnityEngine;
using System;

namespace ScriptableSignal
{
    [CreateAssetMenu(fileName = "Signal Trigger", menuName = "ScriptableSignal/Signal Trigger", order = 0)]
    public class SignalTrigger: ScriptableObject
    {
        [HideInInspector] [SerializeField] private ISignalEvent m_OnUpdateValue;
        public ISignalEvent OnUpdateValue
        {
            get
            {
                if (m_OnUpdateValue == null) m_OnUpdateValue = new SignalEvent();
                return m_OnUpdateValue;
            }
            set { m_OnUpdateValue = value; }
        }

        public void Raise()
        {
            OnUpdateValue.Invoke();
        }
    }
}
