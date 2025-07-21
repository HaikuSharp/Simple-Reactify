using SR.Abstraction;

namespace SR.Overriding.Extensions;

/// <summary>
/// Provides extension methods for converting properties to overridable versions.
/// </summary>
public static class PropertyExtensions
{
    /// <summary>
    /// Wraps an existing property in an <see cref="OverridableWrapProperty{T}"/> instance.
    /// </summary>
    /// <typeparam name="T">The type of the property value.</typeparam>
    /// <param name="obj">The property to wrap.</param>
    /// <returns>A new overridable property that delegates to the original property.</returns>
    public static OverridableWrapProperty<T> AsObservable<T>(this IProperty<T> obj) => new(obj);
}