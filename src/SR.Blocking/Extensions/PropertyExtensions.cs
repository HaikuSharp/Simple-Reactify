using SR.Abstraction;

namespace SR.Blocking.Extensions;

public static class PropertyExtensions
{
    public static BlockableWrapProperty<T> AsBlockable<T>(this IProperty<T> obj) => new(obj);
}
