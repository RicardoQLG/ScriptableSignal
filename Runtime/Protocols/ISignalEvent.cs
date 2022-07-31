using UnityEngine.Events;

namespace ScriptableSignal
{
    public interface ISignalEvent
    {
        public void AddListener(UnityAction action);
        public void RemoveListener(UnityAction action);
        public void Invoke();
    }

    public interface ISignalEvent<T>
    {
        public void AddListener(UnityAction<T> action);
        public void RemoveListener(UnityAction<T> action);
        public void Invoke(T value);
    }
}
