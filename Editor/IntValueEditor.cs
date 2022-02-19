using UnityEditor;

namespace ScriptableSignal
{
    [CustomEditor(typeof(IntValue))]
    public class IntValueEditor : SignalValueEditor<int> {}
}
