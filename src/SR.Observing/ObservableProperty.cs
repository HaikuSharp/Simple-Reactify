using SR.Abstraction;

namespace SR.Observing;

public sealed class ObservableProperty<T>(T value) : ObservableSetterBase<T>, IProperty<T>
{
    public T Get() => value;

    protected override bool InternalSet(T nvalue)
    {
        value = nvalue;
        return true;
    }
}
