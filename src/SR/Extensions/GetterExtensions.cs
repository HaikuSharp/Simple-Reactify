using SR.Abstraction;
using System;

namespace SR.Extensions;

public static class GetterExtensions
{
    public static WrapGetter<T> AsReadOnlyGetter<T>(this IGetter<T> inner) => new(inner);

    public static ScriptableGetter<T> AsGetter<T>(this Func<T> getter) => new(getter);
}
