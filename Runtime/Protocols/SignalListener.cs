using UnityEngine;

namespace ScriptableSignal
{
    public class SignalListener<T> : MonoBehaviour
    {
        public SignalValue<T> SignalValue;

        public SignalEvent<T> OnChangeValue;

        private void OnEnable() => SignalValue.OnUpdateValue.AddListener(OnChangeValue.Invoke);
        private void OnDisable() => SignalValue.OnUpdateValue.RemoveListener(OnChangeValue.Invoke);
    }
}
