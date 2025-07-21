namespace SR.Defaulting.Extensions;

/// <summary>
/// Provides extension methods for converting objects to defaultable properties.
/// </summary>
public static class ObjectExtensions
{
    /// <summary>
    /// Wraps a value in a new <see cref="DefaultableProperty{T}"/> instance.
    /// </summary>
    /// <typeparam name="T">The type of the value.</typeparam>
    /// <param name="obj">The value to wrap.</param>
    /// <returns>A new defaultable property containing the specified value.</returns>
    public static DefaultableProperty<T> AsDefaultableProperty<T>(this T obj) => new(obj);
}