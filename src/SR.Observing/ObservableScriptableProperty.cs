using SR.Abstraction;
using System;

namespace SR.Observing;

public sealed class ObservableScriptableProperty<T>(Func<T> getter, Func<T, bool> setter) : ObservableSetterBase<T>, IProperty<T>
{
    public T Get() => getter();

    protected override bool InternalSet(T value) => setter(value);
}
