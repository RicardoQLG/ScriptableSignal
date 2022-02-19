using UnityEditor;
using UnityEngine;

namespace ScriptableSignal
{
    [CustomEditor(typeof(Vector3Value))]
    public class Vector3ValueEditor : SignalValueEditor<Vector3> {}
}
