using SR.Abstraction;
using System;

namespace SR.Extensions;

public static class SetterExtensions
{
    public static WrapSetter<T> AsWriteOnlySetter<T>(this ISetter<T> inner) => new(inner);

    public static ScriptableSetter<T> AsSetter<T>(this Func<T, bool> setter) => new(setter);
}