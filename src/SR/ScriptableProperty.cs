using SR.Abstraction;
using System;

namespace SR;

public sealed class ScriptableProperty<T>(Func<T> getter, Func<T, bool> setter) : IProperty<T>
{
    public T Get() => getter();

    public bool Set(T value) => setter(value);
}
