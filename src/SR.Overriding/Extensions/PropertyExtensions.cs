using SR.Abstraction;

namespace SR.Overriding.Extensions;

public static class PropertyExtensions
{
    public static OverridableWrapProperty<T> AsObservable<T>(this IProperty<T> obj) => new(obj);
}
