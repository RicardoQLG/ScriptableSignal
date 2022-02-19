using UnityEditor;

namespace ScriptableSignal
{
    [CustomEditor(typeof(FloatValue))]
    public class FloatValueEditor : SignalValueEditor<float> {}
}
