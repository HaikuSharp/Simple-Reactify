namespace SR.Defaulting.Extensions;

public static class ObjectExtensions
{
    public static DefaultableProperty<T> AsDefaultableProperty<T>(this T obj) => new(obj);
}
