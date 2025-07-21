namespace SR.Observing.Extensions;

/// <summary>
/// Provides extension methods for converting objects to observable properties.
/// </summary>
public static class ObjectExtensions
{
    /// <summary>
    /// Wraps a value in a new <see cref="ObservableProperty{T}"/> instance.
    /// </summary>
    /// <typeparam name="T">The type of the value.</typeparam>
    /// <param name="obj">The value to wrap.</param>
    /// <returns>A new observable property containing the specified value.</returns>
    public static ObservableProperty<T> AsObservableProperty<T>(this T obj) => new(obj);
}