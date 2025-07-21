namespace SR.Blocking.Extensions;

public static class ObjectExtensions
{
    public static BlockableProperty<T> AsBlockableProperty<T>(this T obj) => new(obj);
}
