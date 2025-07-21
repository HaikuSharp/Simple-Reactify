using SR.Abstraction;

namespace SR.Observing;

public sealed class ObservableWrapProperty<T>(IProperty<T> inner) : ObservableSetterBase<T>, IProperty<T>
{
    public T Get() => inner.Get();

    protected override bool InternalSet(T value) => inner.Set(value);
}
