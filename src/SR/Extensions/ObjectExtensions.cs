namespace SR.Extensions;

/// <summary>
/// Provides extension methods for converting objects into property accessors.
/// </summary>
public static class ObjectExtensions
{
    /// <summary>
    /// Creates an immutable getter that always returns the original object.
    /// </summary>
    /// <typeparam name="T">The type of the object.</typeparam>
    /// <param name="obj">The object to wrap as a constant value.</param>
    /// <returns>A <see cref="ConstGetter{T}"/> that provides read-only access to the object.</returns>
    public static ConstGetter<T> AsConstGetter<T>(this T obj) => new(obj);

    /// <summary>
    /// Creates a mutable property wrapper around the object.
    /// </summary>
    /// <typeparam name="T">The type of the object.</typeparam>
    /// <param name="obj">The initial value of the property.</param>
    /// <returns>A <see cref="Property{T}"/> that provides read-write access to the value.</returns>
    public static Property<T> AsProperty<T>(this T obj) => new(obj);
}