using SR.Abstraction;
using System;

namespace SR.Overriding;

public sealed class OverridableScriptableProperty<T>(Func<T> getter, Func<T, bool> setter) : OverridableGetterBase<T>, IProperty<T>
{
    protected override T InternalGet() => getter();

    public bool Set(T value) => setter(value);
}
