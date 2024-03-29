using System;
using UnityEngine.Events;

namespace ScriptableSignal
{
  [Serializable]
  public class SignalEvent : UnityEvent, ISignalEvent {}

  [Serializable]
  public class SignalEvent<T> : UnityEvent<T>, ISignalEvent<T> {}
}
