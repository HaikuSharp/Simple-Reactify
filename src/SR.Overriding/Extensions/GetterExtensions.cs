using SR.Abstraction;
using System;

namespace SR.Overriding.Extensions;

public static class GetterExtensions
{
    public static OverridableWrapGetter<T> AsOverridableGetter<T>(this IGetter<T> inner) => new(inner);

    public static OverridableScriptableGetter<T> AsOverridableGetter<T>(this Func<T> getter) => new(getter);
}
