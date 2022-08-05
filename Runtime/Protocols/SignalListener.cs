using UnityEngine;

namespace ScriptableSignal
{
    public class SignalListener : MonoBehaviour
    {
        public SignalTrigger SignalValue;

        public SignalEvent OnChangeValue;

        private void OnEnable() => SignalValue.OnUpdateValue.AddListener(OnChangeValue.Invoke);
        private void OnDisable() => SignalValue.OnUpdateValue.RemoveListener(OnChangeValue.Invoke);
    }

    public class SignalListener<T> : MonoBehaviour
    {
        public SignalValue<T> SignalValue;

        public bool updateOnStart;

        public SignalEvent<T> OnChangeValue;

        private void OnEnable() => SignalValue.OnUpdateValue.AddListener(OnChangeValue.Invoke);
        private void OnDisable() => SignalValue.OnUpdateValue.RemoveListener(OnChangeValue.Invoke);
        private void Start()
        {
            if (updateOnStart)
            {
                SignalValue.Raise();
            }
        }
    }
}
