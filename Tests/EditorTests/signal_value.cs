using NSubstitute;
using NUnit.Framework;
using UnityEngine;

class SutImplementation : SignalValue<float> {}

public class signal_value
{
    private SutImplementation sut;
    private ISignalEvent<float> signalEventStub;

    [SetUp]
    public void SetUp ()
    {
        sut = ScriptableObject.CreateInstance<SutImplementation>();
        signalEventStub = Substitute.For<ISignalEvent<float>>();
    }

    [Test]
    public void signal_value_should_instantiate_SignalEvent_if_not_provided()
    {
        Assert.IsInstanceOf(typeof(ISignalEvent<float>), sut.OnUpdateValue);
    }

    [Test]
    public void signal_value_should_be_able_to_set_OnUpdateValue()
    {
        sut.OnUpdateValue = signalEventStub;
        Assert.AreSame(signalEventStub, sut.OnUpdateValue);
    }

    [Test]
    public void signal_value_should_be_able_to_set_Value()
    {
        sut.Value = 7f;
        Assert.AreEqual(7f, sut.Value);
    }
}
