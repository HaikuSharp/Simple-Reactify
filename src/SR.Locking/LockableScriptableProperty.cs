using SR.Abstraction;
using System;

namespace SR.Locking;

public sealed class LockableScriptableProperty<T>(Func<T> getter, Func<T, bool> setter) : LockableSetterBase<T>, IProperty<T>
{
    public T Get() => getter();

    protected override bool InternalSet(T value) => setter(value);
}
