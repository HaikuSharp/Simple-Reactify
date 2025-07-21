using SR.Abstraction;

namespace SR.Observing;

public sealed class ObservableConstructProperty<T>(IGetter<T> getter, ISetter<T> setter) : ObservableSetterBase<T>, IProperty<T>
{
    public T Get() => getter.Get();

    protected override bool InternalSet(T value) => setter.Set(value);
}
