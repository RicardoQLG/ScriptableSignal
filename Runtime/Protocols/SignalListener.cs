using UnityEngine;

public class SignalListener<T> : MonoBehaviour
{
    public ISignalValue<T> SignalValue;
    public ISignalEvent<T> OnChangeValue;

    private void OnEnable() => SignalValue.OnUpdateValue.AddListener(OnChangeValue.Invoke);
    private void OnDisable() => SignalValue.OnUpdateValue.RemoveListener(OnChangeValue.Invoke);
}