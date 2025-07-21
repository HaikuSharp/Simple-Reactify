using SR.Abstraction;

namespace SR.Observing.Extensions;

/// <summary>
/// Provides extension methods for converting properties to observable versions.
/// </summary>
public static class PropertyExtensions
{
    /// <summary>
    /// Wraps an existing property in an <see cref="ObservableWrapProperty{T}"/> instance.
    /// </summary>
    /// <typeparam name="T">The type of the property value.</typeparam>
    /// <param name="obj">The property to wrap.</param>
    /// <returns>A new observable property that delegates to the original property.</returns>
    public static ObservableWrapProperty<T> AsObservable<T>(this IProperty<T> obj) => new(obj);
}