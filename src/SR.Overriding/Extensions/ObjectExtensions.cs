using SR.Abstraction;

namespace SR.Overriding.Extensions;

public static class ObjectExtensions
{
    public static OverridableConstGetter<T> AsConstOverridableGetter<T>(this T obj) => new(obj);

    public static OverridableProperty<T> AsOverridableProperty<T>(this T obj) => new(obj);
}
