namespace SR.Observing.Extensions;

public static class ObjectExtensions
{
    public static ObservableProperty<T> AsObservableProperty<T>(this T obj) => new(obj);
}
