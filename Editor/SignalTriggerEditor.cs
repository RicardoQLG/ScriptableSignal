using UnityEngine;
using UnityEditor;

namespace ScriptableSignal
{
    [CustomEditor(typeof(SignalTrigger))]
    public class SignalTriggerEditor : Editor {
        private SerializedProperty m_OnUpdateValueProp;

        private void OnEnable()
        {
            m_OnUpdateValueProp = serializedObject.FindProperty("m_OnUpdateValue");
        }

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            var trigger = target as SignalTrigger;
            serializedObject.Update();

            if (GUILayout.Button("Raise"))
            {
                trigger.Raise();
            }
        }
    }
}
