using UnityEngine;
using UnityEditor;

namespace ScriptableSignal
{
    public class SignalValueEditor<T> : Editor {
        private SerializedProperty m_ValueProp;
        private SerializedProperty m_OnUpdateValueProp;

        private void OnEnable()
        {
            m_ValueProp = serializedObject.FindProperty("m_Value");
            m_OnUpdateValueProp = serializedObject.FindProperty("m_OnUpdateValue");
        }

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            serializedObject.Update();

            EditorGUILayout.PropertyField(m_ValueProp, new GUIContent("Value"));

            
            if (serializedObject.hasModifiedProperties)
            {
                serializedObject.ApplyModifiedProperties();
                SignalValue<T> signal = target as SignalValue<T>;
                signal.OnUpdateValue.Invoke(signal.Value);
            }

        }
    }
}
