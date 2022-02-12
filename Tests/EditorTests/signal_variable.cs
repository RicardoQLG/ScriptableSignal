using NSubstitute;
using NUnit.Framework;
using UnityEngine;

class SutImplementation : SignalValue<float> {}

public class signal_variable
{
    [Test]
    public void signal_variable_should_instantiate_SignalEvent_if_not_provided()
    {
        SutImplementation sut = ScriptableObject.CreateInstance<SutImplementation>();
        Assert.IsInstanceOf(typeof(ISignalEvent<float>), sut.OnUpdateValue);
    }

    [Test]
    public void signal_variable_should_be_able_to_set_OnUpdateValue()
    {
        SutImplementation sut = ScriptableObject.CreateInstance<SutImplementation>();
        ISignalEvent<float> signalEvent = Substitute.For<ISignalEvent<float>>();
        sut.OnUpdateValue = signalEvent;
        Assert.AreSame(sut.OnUpdateValue, signalEvent);
    }
}
