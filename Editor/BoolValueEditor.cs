using UnityEditor;

namespace ScriptableSignal
{
    [CustomEditor(typeof(BoolValue))]
    public class BoolValueEditor : SignalValueEditor<bool> {}
}
