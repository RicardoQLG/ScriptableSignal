using UnityEditor;

namespace ScriptableSignal
{
    [CustomEditor(typeof(IntListener))]
    public class IntListenerEditor : SignalListenerEditor<int> {}
}
