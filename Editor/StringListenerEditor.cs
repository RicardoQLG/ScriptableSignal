using UnityEditor;

namespace ScriptableSignal
{
    [CustomEditor(typeof(StringListener))]
    public class StringListenerEditor : SignalListenerEditor<string> {}
}
