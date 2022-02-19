using UnityEditor;
using UnityEngine;

namespace ScriptableSignal
{
    [CustomEditor(typeof(Vector3Listener))]
    public class Vector3ListenerEditor : SignalListenerEditor<Vector3> {}
}
