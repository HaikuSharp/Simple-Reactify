using SR.Abstraction;

namespace SR.Defaulting.Extensions;

/// <summary>
/// Provides extension methods for converting properties to defaultable versions.
/// </summary>
public static class PropertyExtensions
{
    /// <summary>
    /// Wraps an existing property in a <see cref="DefaultableWrapProperty{T}"/> instance.
    /// </summary>
    /// <typeparam name="T">The type of the property value.</typeparam>
    /// <param name="obj">The property to wrap.</param>
    /// <returns>A new defaultable property that delegates to the original property.</returns>
    public static DefaultableWrapProperty<T> AsDefaultable<T>(this IProperty<T> obj) => new(obj);
}