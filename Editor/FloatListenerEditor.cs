using UnityEditor;

namespace ScriptableSignal
{
    [CustomEditor(typeof(FloatListener))]
    public class FloatListenerEditor : SignalListenerEditor<float> {}
}
