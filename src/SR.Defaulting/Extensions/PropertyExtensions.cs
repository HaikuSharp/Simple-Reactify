using SR.Abstraction;

namespace SR.Defaulting.Extensions;

public static class PropertyExtensions
{
    public static DefaultableWrapProperty<T> AsDefaultable<T>(this IProperty<T> obj) => new(obj);
}
