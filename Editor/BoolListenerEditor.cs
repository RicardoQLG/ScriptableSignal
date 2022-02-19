using UnityEditor;

namespace ScriptableSignal
{
    [CustomEditor(typeof(BoolListener))]
    public class BoolListenerEditor : SignalListenerEditor<bool> {}
}
