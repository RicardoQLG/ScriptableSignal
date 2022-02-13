using System;
using UnityEngine.Events;

[Serializable]
public class SignalEvent<T> : UnityEvent<T>, ISignalEvent<T> {}