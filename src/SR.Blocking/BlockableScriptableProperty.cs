using System;

namespace SR.Blocking;

public sealed class BlockableScriptableProperty<T>(Func<T> getter, Func<T, bool> setter) : BlockablePropertyBase<T>()
{
    public override T Get() => getter();

    protected override bool InternalSet(T value) => setter(value);
}
