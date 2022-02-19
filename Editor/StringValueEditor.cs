using UnityEditor;

namespace ScriptableSignal
{
    [CustomEditor(typeof(StringValue))]
    public class StringValueEditor : SignalValueEditor<string> {}
}
