using System.Collections;
using UnityEngine;

namespace ScriptableSignal
{
    [RequireComponent(typeof(Collider))]
    public class TriggerChecker : MonoBehaviour
    {
        [SerializeField] private BoolValue m_Checker;
        [SerializeField] private float m_DelayToTrue;
        [SerializeField] private float m_DelayToFalse;

        private void OnTriggerStay(Collider other)
        {
            StartCoroutine(TriggerStayCoroutine());
        }

        private IEnumerator TriggerStayCoroutine()
        {
            yield return new WaitForSeconds(m_DelayToTrue);
            m_Checker.Value = true;
        }

        private void OnTriggerExit(Collider other)
        {
            StartCoroutine(TriggerExitCoroutine());
        }

        private IEnumerator TriggerExitCoroutine()
        {
            yield return new WaitForSeconds(m_DelayToFalse);
            m_Checker.Value = false;
        }
    }
}