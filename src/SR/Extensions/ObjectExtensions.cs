namespace SR.Extensions;

public static class ObjectExtensions
{
    public static ConstGetter<T> AsConstGetter<T>(this T obj) => new(obj);

    public static Property<T> AsProperty<T>(this T obj) => new(obj);
}
