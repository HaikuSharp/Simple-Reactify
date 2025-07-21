using SR.Abstraction;

namespace SR.Observing.Extensions;

public static class PropertyExtensions
{
    public static ObservableWrapProperty<T> AsObservable<T>(this IProperty<T> obj) => new(obj);
}
