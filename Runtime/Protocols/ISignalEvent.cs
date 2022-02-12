using UnityEngine.Events;

public interface ISignalEvent<T>
{
    public void AddListener(UnityAction<T> action);
    public void RemoveListener(UnityAction<T> action);
    public void Invoke(T value);
}