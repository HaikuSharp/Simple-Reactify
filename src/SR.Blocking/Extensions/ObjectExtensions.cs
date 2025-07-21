namespace SR.Blocking.Extensions;

/// <summary>
/// Provides extension methods for converting objects to blockable properties.
/// </summary>
public static class ObjectExtensions
{
    /// <summary>
    /// Wraps a value in a new <see cref="BlockableProperty{T}"/> instance.
    /// </summary>
    /// <typeparam name="T">The type of the value.</typeparam>
    /// <param name="obj">The value to wrap.</param>
    /// <returns>
    /// A new <see cref="BlockableProperty{T}"/> containing the specified value.
    /// </returns>
    public static BlockableProperty<T> AsBlockableProperty<T>(this T obj) => new(obj);
}