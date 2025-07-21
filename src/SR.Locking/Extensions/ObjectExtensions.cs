namespace SR.Locking.Extensions;

/// <summary>
/// Provides extension methods for converting objects to lockable properties.
/// </summary>
public static class ObjectExtensions
{
    /// <summary>
    /// Wraps a value in a new <see cref="LockableProperty{T}"/> instance.
    /// </summary>
    /// <typeparam name="T">The type of the value.</typeparam>
    /// <param name="obj">The value to wrap.</param>
    /// <returns>A new lockable property containing the specified value.</returns>
    public static LockableProperty<T> AsLockableProperty<T>(this T obj) => new(obj);
}