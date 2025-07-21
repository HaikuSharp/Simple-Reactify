using SR.Abstraction;
using System;

namespace SR.Locking;

public sealed class LockableScriptableSetter<T>(Func<T, bool> inner) : LockableSetterBase<T>, ISetter<T>
{
    protected override bool InternalSet(T value) => inner(value);
}
