using System.Collections;
using NSubstitute;
using UnityEngine;
using UnityEngine.TestTools;

namespace Listener {
    class SutImplementation : SignalListener<string> {}
    class SignalValueImplementation : SignalValue<string> {}

    public class signal_listener
    {
        [UnityTest]
        public IEnumerator signal_listener_should_call_on_change_value()
        {
            GameObject gameObject = new GameObject();
            gameObject.SetActive(false);
            SutImplementation sut = gameObject.AddComponent<SutImplementation>();
            sut.SignalValue = ScriptableObject.CreateInstance<SignalValueImplementation>();
            sut.OnChangeValue = Substitute.For<ISignalEvent<string>>();
            gameObject.SetActive(true);
            sut.SignalValue.Value = "valid_string";
            yield return null;
            sut.OnChangeValue.Received().Invoke("valid_string");
        }
    }
}