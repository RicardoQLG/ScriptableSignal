namespace ScriptableSignal
{
    public interface ISignalValue<T>
    {
        public ISignalEvent<T> OnUpdateValue { get; set; }
        public T Value { get; set; }
    }
}
