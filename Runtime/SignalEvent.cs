using UnityEngine.Events;

public class SignalEvent<T> : UnityEvent<T>, ISignalEvent<T> {}