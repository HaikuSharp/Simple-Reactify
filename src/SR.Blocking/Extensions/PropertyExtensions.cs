using SR.Abstraction;

namespace SR.Blocking.Extensions;

/// <summary>
/// Provides extension methods for converting properties to blockable versions.
/// </summary>
public static class PropertyExtensions
{
    /// <summary>
    /// Wraps an existing property in a <see cref="BlockableWrapProperty{T}"/> instance.
    /// </summary>
    /// <typeparam name="T">The type of the property value.</typeparam>
    /// <param name="obj">The property to wrap.</param>
    /// <returns>
    /// A new <see cref="BlockableWrapProperty{T}"/> that delegates to the original property
    /// while adding blocking capabilities.
    /// </returns>
    public static BlockableWrapProperty<T> AsBlockable<T>(this IProperty<T> obj) => new(obj);
}