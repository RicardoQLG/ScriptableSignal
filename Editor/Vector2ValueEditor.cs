using UnityEditor;
using UnityEngine;

namespace ScriptableSignal
{
    [CustomEditor(typeof(Vector2Value))]
    public class Vector2ValueEditor : SignalValueEditor<Vector2> {}
}
