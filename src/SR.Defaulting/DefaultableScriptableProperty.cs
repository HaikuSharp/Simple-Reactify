using System;

namespace SR.Defaulting;

public sealed class DefaultableScriptableProperty<T>(Func<T> getter, Func<T, bool> setter) : DefaultablePropertyBase<T>()
{
    public override T Get() => getter();

    public override bool Set(T value) => setter(value);
}
