using SR.Abstraction;
using System;

namespace SR.Locking.Extensions;

public static class SetterExtensions
{
    public static LockableWrapSetter<T> AsWriteOnlyLockableSetter<T>(this ISetter<T> inner) => new(inner);

    public static LockableScriptableSetter<T> AsLockableSetter<T>(this Func<T, bool> setter) => new(setter);
}