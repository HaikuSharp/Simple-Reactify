using SR.Abstraction;

namespace SR.Observing;

public sealed class ObservableWrapSetter<T>(ISetter<T> inner) : ObservableSetterBase<T>
{
    protected override bool InternalSet(T value) => inner.Set(value);
}
