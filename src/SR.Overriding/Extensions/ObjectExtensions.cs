using SR.Abstraction;

namespace SR.Overriding.Extensions;

/// <summary>
/// Provides extension methods for converting objects to overridable getters and properties.
/// </summary>
public static class ObjectExtensions
{
    /// <summary>
    /// Creates a constant overridable getter from a value.
    /// </summary>
    /// <typeparam name="T">The type of the value.</typeparam>
    /// <param name="obj">The value to wrap.</param>
    /// <returns>A new constant overridable getter containing the specified value.</returns>
    public static OverridableConstGetter<T> AsConstOverridableGetter<T>(this T obj) => new(obj);

    /// <summary>
    /// Creates an overridable property from a value.
    /// </summary>
    /// <typeparam name="T">The type of the value.</typeparam>
    /// <param name="obj">The value to wrap.</param>
    /// <returns>A new overridable property containing the specified value.</returns>
    public static OverridableProperty<T> AsOverridableProperty<T>(this T obj) => new(obj);
}