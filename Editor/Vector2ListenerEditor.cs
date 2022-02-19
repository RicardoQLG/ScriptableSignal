using UnityEditor;
using UnityEngine;

namespace ScriptableSignal
{
    [CustomEditor(typeof(Vector2Listener))]
    public class Vector2ListenerEditor : SignalListenerEditor<Vector2> {}
}
